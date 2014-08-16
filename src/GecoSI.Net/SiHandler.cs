﻿using System;
using System.Collections.Concurrent;
using System.IO;
using System.IO.Ports;
using System.Threading;
using GecoSI.Net.Adapter.LogFie;
using GecoSI.Net.Adapter.SerialPort;
using GecoSI.Net.Dataframe;

namespace GecoSI.Net
{
    public class SiHandler
    {
        private readonly BlockingCollection<ISiDataFrame> dataQueue;

        private readonly ISiListener siListener;

        private SiDriver driver;

        private Thread thread;
        private long zerohour;

        public SiHandler()
        {
            dataQueue = new BlockingCollection<ISiDataFrame>();
        }

        public SiHandler(ISiListener siListener)
        {
            dataQueue = new BlockingCollection<ISiDataFrame>();
            this.siListener = siListener;
        }

        public void SetZeroHour(long zerohour)
        {
            this.zerohour = zerohour;
        }

        public void Connect(String portname)
        {
            try
            {
                GecoSiLogger.Open("######");
                GecoSiLogger.LogTime("Start " + portname);
                Start();
                var port = new SerialPort(portname, 2000);
                port.Open();
                driver = new SiDriver(new SerialComPort(port), this).Start();
            }
            catch (Exception e)
            {
                siListener.Notify(CommStatus.FatalError, "Port in use");
            }
        }

        public void ReadLog(String logFilename)
        {
            try
            {
                GecoSiLogger.OpenOutStreamLogger();
                Start();
                driver = new SiDriver(new LogFilePort(logFilename), this).Start();
            }
            catch (Exception e)
            {
                e.PrintStackTrace();
            }
        }

        public void Start()
        {
            thread = new Thread(Run);
            thread.Start();
        }

        public Thread Stop()
        {
            if (driver != null)
            {
                driver.Interrupt();
            }
            if (thread != null)
            {
                thread.Interrupt();
            }
            return thread;
        }

        public bool IsAlive()
        {
            return thread != null && thread.IsAlive;
        }

        public virtual void Notify(ISiDataFrame data)
        {
            data.StartingAt(zerohour);
            dataQueue.Add(data); // TODO check true
        }

        public virtual void Notify(CommStatus status)
        {
            GecoSiLogger.Log("!", status.GetType().Name);
            siListener.Notify(status);
        }


        public virtual void NotifyError(CommStatus errorStatus, String errorMessage)
        {
            GecoSiLogger.Error(errorMessage);
            siListener.Notify(errorStatus, errorMessage);
        }

        public void Run()
        {
            try
            {
                ISiDataFrame dataFrame;
                while ((dataFrame = dataQueue.Take()) != null)
                {
                    siListener.HandleEcard(dataFrame);
                }
            }
            catch (ThreadInterruptedException e)
            {
                dataQueue.Dispose();
            }
        }
    }
}