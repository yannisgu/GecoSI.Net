﻿using GecoSI.Net.Internal;

namespace GecoSI.Net.Tests
{
    public class SiMessageFixtures
    {
        public static SiMessage startup_answer = new SiMessage(
            new byte[] {0x02, 0xF0, 0x03, 0x00, 0x01, 0x4D, 0x0D, 0x11, 0x03});

        public static SiMessage ok_ext_protocol_answer = new SiMessage(
            new byte[] {0x02, 0x83, 0x04, 0x00, 0x01, 0x74, 0x05, 0xB1, 0x64, 0x03});

        public static SiMessage no_ext_protocol_answer = new SiMessage(new byte[]
        {
            0x02, 0x83, 0x04, 0x00, 0x01, 0x74, 0x04, 0x31, 0x61, 0x03
        });

        public static SiMessage no_handshake_answer = new SiMessage(new byte[]
        {
            0x02, 0x83, 0x04, 0x00, 0x01, 0x74, 0x03, 0xB1, 0x70, 0x03
        });

        public static SiMessage si6_64_punches_answer = new SiMessage(new byte[]
        {
            0x02, 0x83, 0x04, 0x00, 0x01, 0x33, 0xC1, 0x21, 0xFA, 0x03
        });

        public static SiMessage si6_192_punches_answer = new SiMessage(new byte[]
        {
            0x02, 0x83, 0x04, 0x00, 0x01, 0x33, 0xFF, 0xA1, 0x7D, 0x03
        });

        public static SiMessage sicard5_detected = new SiMessage(new byte[]
        {
            0x02, 0xE5, 0x06, 0x00, 0x01, 0x00, 0x03, 0x10, 0x93, 0xB7, 0x37, 0x03
        });

        public static SiMessage sicard5_data = new SiMessage(new byte[]
        {
            0x02, 0xB1, 0x82, 0x00, 0x01, 0xAA, 0x2E, 0x00, 0x01, 0x10, 0x93, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00,
            0x00, 0x00, 0x65, 0x10, 0x93, 0xEE, 0xEE, 0x01, 0xF8, 0x0B, 0x56, 0xEE, 0xEE, 0x28, 0x03,
            0xA6, 0x00, 0x07, 0x00, 0x24, 0x9C, 0x7B, 0x26, 0x9C, 0x8C, 0x22, 0x9C, 0x8D, 0x28, 0x9C,
            0x8F, 0x34, 0x9C, 0x9B, 0x00, 0x36, 0x9C, 0x9F, 0x33, 0x9C, 0xA1, 0x35, 0x9C,
            0xA2, 0x3C, 0x9C, 0xA7, 0x3B, 0x9C, 0xA8, 0x00, 0x00, 0xEE, 0xEE, 0x00, 0xEE,
            0xEE, 0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE, 0x00, 0x00, 0xEE,
            0xEE, 0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE,
            0x00, 0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE,
            0x00, 0xEE, 0xEE, 0x00, 0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE,
            0x00, 0xEE, 0xEE, 0x00, 0xEE, 0xEE, 0x86, 0xC8, 0x03
        });

        public static SiMessage sicard5_removed = new SiMessage(new byte[]
        {
            0x02, 0xE7, 0x06, 0x00, 0x01, 0x00, 0x03, 0x10, 0x93, 0x97, 0x3B, 0x03
        });

        public static SiMessage sicard6_detected = new SiMessage(new byte[]
        {
            0x02, 0xE6, 0x06, 0x00, 0x01, 0x00, 0x07, 0xA1, 0x20, 0xB0, 0xFE, 0x03
        });

        public static SiMessage sicard6Star_detected = new SiMessage(new byte[]
        {
            0x02, 0xE6, 0x06, 0x00, 0x01, 0x00, 0xFF, 0x00, 0x00, 0x68, 0x64, 0x03
        });

        public static SiMessage sicard6_b0_data = new SiMessage(new byte[]
        {
            0x02, 0xE1, 0x83, 0x00, 0x06, 0x00, 0x01, 0x01, 0x01, 0x01, 0xED, 0xED, 0xED, 0xED, 0x55,
            0xAA, 0x00, 0x0C, 0x87, 0x0B, 0xBA, 0xA3, 0x00, 0x23, 0x05, 0x06, 0x06, 0x0A, 0x8B, 0x44, 0x06,
            0x07, 0x8A, 0xED, 0x06, 0x04, 0x8A, 0xEB, 0x06, 0x06, 0x8A, 0xD9, 0xEE, 0xEE,
            0xEE, 0xEE, 0x00, 0x00, 0x00, 0x00, 0x20, 0x20, 0x20, 0x20, 0x4D, 0x61, 0x72, 0x69, 0x71, 0x75, 0x65, 0x20,
            0x20, 0x20,
            0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x52, 0x6F, 0x62, 0x65, 0x72, 0x74, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x48, 0x65, 0x72, 0x6D, 0x61, 0x74,
            0x68, 0x65, 0x6E, 0x61,
            0x65, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20, 0x9E, 0xB7, 0x03
        });

        public static SiMessage sicard6_b6_data = new SiMessage(new byte[]
        {
            0x02, 0xE1, 0x83, 0x00, 0x06, 0x06, 0x06, 0x1F, 0x8B, 0x05, 0x06, 0x20, 0x8B, 0x12, 0x06, 0x21, 0x8B,
            0x1D, 0x06, 0x22, 0x8B, 0x28, 0x06, 0x23, 0x8B, 0x33, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xBD, 0x11, 0x03
        });

        public static SiMessage sicard6_b7_data = new SiMessage(new byte[]
        {
            0x02, 0xE1, 0x83, 0x00, 0x06, 0x07, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0x86, 0xE3, 0x03
        });

        public static SiMessage sicard8_detected = new SiMessage(new byte[]
        {
            0x02, 0xE8, 0x06, 0x00, 0x01, 0x02, 0x1E, 0x99, 0x5B, 0xFA, 0x04, 0x03
        });

        public static SiMessage sicard8_b0_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x00, 0xDA, 0xEE, 0xA7, 0x71, 0xEA, 0xEA, 0xEA,
            0xEA, 0x35, 0x03, 0x70, 0x4D, 0x35, 0x01, 0x70, 0x4E, 0x35, 0x02, 0x70, 0x78, 0x00, 0x1F, 0x01, 0xF2, 0x02,
            0x1E,
            0x99, 0x53, 0x0C, 0xFF, 0xDD, 0x6F, 0x32, 0x30, 0x30, 0x35, 0x33, 0x33, 0x31, 0x3B, 0x43, 0x68, 0x72, 0x6F,
            0x6E,
            0x6F, 0x52, 0x41, 0x49, 0x44, 0x3B, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x67, 0x90, 0x03
        });

        public static SiMessage sicard8_b1_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x35, 0x1F, 0x70, 0x62,
            0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0x6C, 0x64, 0x03
        });

        public static SiMessage sicard9_b0_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x00, 0xAD, 0xC3, 0xAC, 0x72, 0xEA, 0xEA, 0xEA,
            0xEA, 0x20, 0x04, 0x9D, 0xA7, 0x10, 0xCE, 0x9E, 0x71, 0x11, 0xC9, 0x03, 0xAF, 0x00,
            0xC8, 0x13, 0x83, 0x01, 0x10, 0x32, 0x87, 0x0C, 0xFF, 0xBE, 0x10, 0x53, 0x69, 0x6D, 0x6F, 0x6E, 0x3B,
            0x44, 0x45, 0x4E, 0x49, 0x45, 0x52, 0x3B, 0x00, 0x00, 0x00, 0x49, 0x44, 0x3B, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x30, 0x86, 0x9E,
            0xE7, 0x30, 0x8D, 0x9F, 0x3F, 0x30, 0x8F, 0x9F, 0x8C, 0x30, 0x90, 0x9F, 0xE7,
            0x30, 0x95, 0xA0, 0x37, 0x30, 0x97, 0xA0, 0xF7, 0x30, 0x98, 0xA1, 0x62, 0x30, 0x9C,
            0xA1, 0xDA, 0x30, 0x9E, 0xA6, 0xAB, 0x30, 0xA0, 0xA7, 0xAA, 0x30, 0xA1,
            0xA8, 0x16, 0x31, 0xA4, 0x00, 0x08, 0x31, 0xA5, 0x00, 0x9E, 0x31, 0xA3, 0x01, 0x1F, 0x11, 0xAB,
            0x02, 0x78, 0x11, 0xAD, 0x03, 0x11, 0x11, 0xAF, 0x03, 0x3D, 0x31, 0xA9, 0x03, 0x85, 0x87, 0x1E, 0x03
        });

        public static SiMessage sicard9_b1_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x01, 0x11, 0xC8, 0x03, 0xA3, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0x23, 0xCA, 0x03
        });

        public static SiMessage sicard10_detected = new SiMessage(new byte[]
        {
            0x02, 0xE8, 0x06, 0x00, 0x01, 0x0F, 0x76, 0x9E, 0x72, 0x0B, 0xD2, 0x03
        });

        public static SiMessage sicard10_b0_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x00, 0x89, 0xB9, 0x4E, 0x99, 0xEA, 0xEA, 0xEA,
            0xEA, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0x02, 0xFE, 0x03, 0xE3, 0x0F, 0x76, 0x9E, 0x72, 0x01, 0x0D, 0xB8,
            0x14, 0x45, 0x72, 0x69, 0x63, 0x3B, 0x4D, 0x45, 0x52, 0x4D, 0x49, 0x4E, 0x3B, 0x6D, 0x3B, 0x31, 0x39, 0x36,
            0x31, 0x3B, 0x4F, 0x52,
            0x49, 0x45, 0x4E, 0x74, 0x99, 0x27, 0x41, 0x4C, 0x50, 0x3B, 0x65, 0x72, 0x69, 0x63, 0x2E, 0x6D, 0x65, 0x72,
            0x6D, 0x69, 0x6E,
            0x40, 0x66, 0x72, 0x65, 0x65, 0x2E, 0x66, 0x72, 0x3B, 0x3B, 0x56, 0x49, 0x5A, 0x49, 0x4C, 0x4C, 0x45, 0x3B,
            0x33, 0x30, 0x34, 0x20,
            0x61, 0x76, 0x65, 0x6E, 0x75, 0x65, 0x20, 0x61, 0x72, 0x69, 0x73, 0x74, 0x69, 0x64, 0x65, 0x20, 0x62, 0x72,
            0x69, 0x61, 0x6E, 0x64,
            0x3B, 0x33, 0x38, 0x32, 0x32, 0x30, 0x3B, 0x46, 0x52, 0x41, 0x61, 0xAA, 0x03
        });

        public static SiMessage sicard10_b1_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x01, 0x3B, 0x00, 0x00, 0x00, 0x52, 0x41, 0x3B, 0x00, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEB, 0xEB, 0xEB, 0xEB, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xDA, 0x9A, 0x03
        });

        public static SiMessage sicard10_b2_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x02, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEC, 0xEC,
            0xEC, 0xEC, 0x17, 0xAA, 0x03
        });

        public static SiMessage sicard10_b3_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x03, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0x0D, 0x01, 0x08, 0x01, 0x01, 0x02, 0x02, 0x05, 0xFF, 0xFF,
            0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x18, 0x00, 0x05, 0x4A, 0x08, 0x00, 0x05, 0x0A, 0x05,
            0xAA, 0x01, 0x8E, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xCA, 0xAA, 0xCC, 0xAC, 0xAC, 0xCA, 0xAA, 0xAC, 0xCA, 0xAA,
            0xCA, 0xAC, 0xCC, 0xCC, 0xAA, 0xAA, 0x73, 0x69, 0x61, 0x63, 0xFF, 0xFF,
            0xFF, 0xFF, 0x87, 0xE4, 0xE8, 0x02, 0x06, 0xDE, 0x00, 0x00, 0x3E, 0xD9, 0x03
        });

        public static SiMessage sicard10_b4_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x04, 0x05, 0x2A, 0x09, 0xCA, 0x05, 0x26, 0x09, 0xD1, 0x29, 0x20, 0x14,
            0x4D, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0x78, 0x0A, 0x03
        });

        public static SiMessage sicard10_b5_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x05, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xFB, 0x8D, 0x03
        });

        public static SiMessage sicard10_b6_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x06, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xC1, 0x8D, 0x03
        });

        public static SiMessage sicard10_b7_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x07, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0x00, 0xC4, 0x00,
            0xC4, 0x8E, 0xB2, 0x03
        });

        public static SiMessage sicard11_detected = new SiMessage(new byte[]
        {
            0x02, 0xE8, 0x06, 0x00, 0x01, 0x0F, 0x98, 0x7E, 0x52, 0xC6, 0x45, 0x03
        });

        public static SiMessage sicard11_b0_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x00, 0xB2, 0x23, 0xE1, 0x98, 0xEA, 0xEA, 0xEA,
            0xEA, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0x12, 0x01, 0x7F,
            0xB9, 0x03, 0xE3, 0x04, 0xB0, 0x0F, 0x98, 0x7E, 0x52, 0x01, 0x0D, 0x0A, 0xB0, 0x45, 0x72, 0x69, 0x63,
            0x3B, 0x4D, 0x45, 0x52, 0x4D, 0x49, 0x4E, 0x3B, 0x6D, 0x3B, 0x31, 0x39, 0x36, 0x31, 0x3B, 0x3B, 0x65, 0x72,
            0x69, 0x63, 0x2E, 0x6D, 0x65,
            0x72, 0x6D, 0x69, 0x6E, 0x40, 0x66, 0x72, 0x65, 0x65, 0x2E, 0x66, 0x72, 0x3B, 0x3B, 0x56, 0x49, 0x5A, 0x49,
            0x4C, 0x4C, 0x45, 0x3B, 0x33,
            0x30, 0x34, 0x20, 0x61, 0x76, 0x65, 0x6E, 0x75, 0x65, 0x20, 0x61, 0x72, 0x69, 0x73, 0x74, 0x69, 0x64, 0x65,
            0x20, 0x62, 0x72, 0x69, 0x61,
            0x6E, 0x64, 0x3B, 0x33, 0x38, 0x32, 0x32, 0x30, 0x3B, 0x46, 0x52, 0x41, 0x3B, 0x00, 0x00, 0x46, 0x52, 0x41,
            0x3B, 0xEE, 0xEE,
            0xEE, 0xEE, 0x78, 0x95, 0x03
        });

        public static SiMessage sicard11_b4_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x04, 0x09, 0x26, 0x2D, 0xB7, 0x05, 0x2A, 0x0B, 0x7F, 0x05, 0x26, 0x0B, 0x8A,
            0x29, 0x20, 0x14, 0xC0, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xD0, 0xED, 0x03
        });

        public static SiMessage sicard11_b5_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x05, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xFB, 0x8D, 0x03
        });

        public static SiMessage sicard11_b6_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x06, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xC1, 0x8D, 0x03
        });

        public static SiMessage sicard11_b7_data = new SiMessage(new byte[]
        {
            0x02, 0xEF, 0x83, 0x00, 0x01, 0x07, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0x00, 0xC4, 0x00,
            0xC4, 0x8E, 0xB2, 0x03
        });

        public static SiMessage sicard6_192p_b0_data = new SiMessage(new byte[]
        {
            0x02, 0xE1, 0x83, 0x00, 0x06, 0x00, 0x01, 0x01, 0x01, 0x02, 0xED, 0xED, 0xED, 0xED, 0x55,
            0xAA, 0x00, 0x0C, 0x87, 0x0B, 0xBA, 0xA3, 0x80, 0x7A, 0x65, 0x66, 0x0D, 0x0A, 0x15, 0x6C, 0x06, 0x08,
            0x8F, 0x90, 0x06, 0x04, 0x8F, 0x8E, 0x06, 0x07, 0x8F, 0x8B, 0xEE, 0xEE,
            0xEE, 0xEE, 0x00, 0x00, 0x00, 0x00, 0x20, 0x20, 0x20, 0x20, 0x4D, 0x61, 0x72, 0x69, 0x71, 0x75, 0x65, 0x20,
            0x20, 0x20,
            0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x52, 0x6F, 0x62, 0x65, 0x72, 0x74, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x48, 0x65, 0x72, 0x6D, 0x61, 0x74,
            0x68, 0x65, 0x6E, 0x61,
            0x65, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20, 0xF0, 0x22, 0x03
        });

        public static SiMessage sicard6_192p_b1_data = new SiMessage(new byte[]
        {
            0x02, 0xE1, 0x83, 0x00, 0x06, 0x01, 0x33, 0x37, 0x30, 0x35, 0x43, 0x45, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20,
            0x20, 0x20,
            0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20,
            0x72, 0x6D, 0x61, 0x40,
            0x68, 0x65, 0x6C, 0x67, 0x61, 0x2D, 0x6F, 0x2E, 0x63, 0x6F, 0x6D, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x20, 0x30, 0x30, 0x30, 0x6D, 0x20, 0x20, 0x20, 0x20,
            0x20, 0x20, 0x20, 0x20,
            0x06, 0x03, 0x14, 0x06, 0x31, 0x29, 0x03
        });

        public static SiMessage sicard6_192p_b2_data = new SiMessage(new byte[]
        {
            0x02, 0xE1, 0x83, 0x00, 0x06, 0x02, 0x06, 0x23, 0x90, 0x4F, 0x06, 0x1F, 0x90, 0x53, 0x06, 0x20, 0x90,
            0x55, 0x06, 0x21, 0x90, 0x57, 0x06, 0x22, 0x90, 0x59, 0x06, 0x23, 0x90, 0x5C, 0x06, 0x1F, 0x90, 0x60, 0x06,
            0x20, 0x90, 0x62, 0x06, 0x21, 0x90, 0x64, 0x06, 0x22, 0x90, 0x66, 0x06, 0x23, 0x90, 0x69, 0x06, 0x1F,
            0x90, 0x6E, 0x06, 0x20, 0x90, 0x72, 0x06, 0x21, 0x90, 0x77, 0x06, 0x22, 0x90, 0x7A, 0x06, 0x23, 0x90,
            0x7D, 0x06, 0x1F, 0x90, 0x82, 0x06, 0x20, 0x90, 0x84, 0x06, 0x21, 0x90, 0x87, 0x06, 0x22,
            0x90, 0x89, 0x06, 0x23, 0x90, 0x8B, 0x06, 0x1F, 0x90, 0x8F, 0x06, 0x20, 0x90,
            0x91, 0x06, 0x21, 0x90, 0x93, 0x06, 0x22, 0x90, 0x96, 0x06, 0x23, 0x90, 0x98, 0x06,
            0x1F, 0x90, 0x9C, 0x06, 0x20, 0x90, 0x9D, 0x06, 0x21, 0x90, 0x9F, 0x06, 0x22, 0x90,
            0xA2, 0x06, 0x23, 0x90, 0xA4, 0x06, 0x1F, 0x90, 0xA8, 0xF2, 0x19, 0x03
        });

        public static SiMessage sicard6_192p_b3_data = new SiMessage(new byte[]
        {
            0x02, 0xE1, 0x83, 0x00, 0x06, 0x03, 0x06, 0x20, 0x90, 0xAA, 0x06, 0x21, 0x90, 0xAC, 0x06, 0x22,
            0x90, 0xAE, 0x06, 0x23, 0x90, 0xB0, 0x8D, 0x7A, 0x15, 0x31, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xB5, 0x9B, 0x03
        });

        public static SiMessage sicard6_192p_b4_data = new SiMessage(new byte[]
        {
            0x02, 0xE1, 0x83, 0x00, 0x06, 0x04, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xBC, 0xE3, 0x03
        });

        public static SiMessage sicard6_192p_b5_data = new SiMessage(new byte[]
        {
            0x02, 0xE1, 0x83, 0x00, 0x06, 0x05, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE, 0xEE,
            0xEE, 0xEE, 0xAA, 0xE3, 0x03
        });

        public static SiMessage sicard6_192p_b6_data = new SiMessage(new byte[]
        {
            0x02, 0xE1, 0x83, 0x00, 0x06, 0x06, 0x06, 0x1F, 0x8F, 0x9A, 0x06, 0x20, 0x8F, 0x9C, 0x06,
            0x21, 0x8F, 0x9E, 0x06, 0x22, 0x8F, 0xA0, 0x06, 0x23, 0x8F, 0xA3, 0x06, 0x1F, 0x8F,
            0xAB, 0x06, 0x20, 0x8F, 0xAD, 0x06, 0x21, 0x8F, 0xAF, 0x06, 0x22, 0x8F, 0xB1, 0x06,
            0x23, 0x8F, 0xB3, 0x06, 0x1F, 0x8F, 0xB7, 0x06, 0x20, 0x8F, 0xB9, 0x06, 0x21, 0x8F,
            0xBB, 0x06, 0x22, 0x8F, 0xBE, 0x06, 0x23, 0x8F, 0xC1, 0x06, 0x1F, 0x8F, 0xC6, 0x06,
            0x20, 0x8F, 0xC9, 0x06, 0x21, 0x8F, 0xCB, 0x06, 0x22, 0x8F, 0xCD, 0x06, 0x23, 0x8F,
            0xD0, 0x06, 0x1F, 0x8F, 0xD5, 0x06, 0x20, 0x8F, 0xD7, 0x06, 0x21, 0x8F, 0xD9, 0x06,
            0x22, 0x8F, 0xDB, 0x06, 0x23, 0x8F, 0xDD, 0x06, 0x1F, 0x8F, 0xE2, 0x06, 0x20, 0x8F,
            0xE4, 0x06, 0x21, 0x8F, 0xE6, 0x06, 0x22, 0x8F, 0xE8, 0x06, 0x23, 0x8F, 0xEA, 0x06,
            0x1F, 0x8F, 0xEF, 0x06, 0x20, 0x8F, 0xF1, 0xE7, 0xF0, 0x03
        });

        public static SiMessage sicard6_192p_b7_data = new SiMessage(new byte[]
        {
            0x02, 0xE1, 0x83, 0x00, 0x06, 0x07, 0x06, 0x21, 0x8F, 0xF3, 0x06, 0x22, 0x8F, 0xF5, 0x06,
            0x23, 0x8F, 0xF8, 0x06, 0x1F, 0x8F, 0xFD, 0x06, 0x20, 0x8F, 0xFF, 0x06, 0x21, 0x90,
            0x01, 0x06, 0x22, 0x90, 0x03, 0x06, 0x23, 0x90, 0x06, 0x06, 0x1F, 0x90, 0x0A, 0x06, 0x20, 0x90, 0x0D,
            0x06, 0x21, 0x90, 0x0F, 0x06, 0x22, 0x90, 0x12, 0x06, 0x23, 0x90, 0x15, 0x06, 0x1F, 0x90, 0x1A, 0x06,
            0x20, 0x90, 0x1C, 0x06, 0x21, 0x90, 0x1F, 0x06, 0x22, 0x90, 0x22, 0x06, 0x23, 0x90, 0x24, 0x06, 0x1F,
            0x90, 0x29, 0x06, 0x20, 0x90, 0x2B, 0x06, 0x21, 0x90, 0x2E, 0x06, 0x22, 0x90, 0x30, 0x06, 0x23, 0x90,
            0x33, 0x06, 0x1F, 0x90, 0x37, 0x06, 0x20, 0x90, 0x3A, 0x06, 0x21, 0x90, 0x3C, 0x06, 0x22, 0x90, 0x3F, 0x06,
            0x23, 0x90, 0x41, 0x06, 0x1F, 0x90, 0x45, 0x06, 0x20, 0x90, 0x47, 0x06, 0x21, 0x90, 0x49, 0x06, 0x22,
            0x90, 0x4C, 0x8D, 0xC9, 0x03
        });
    }
}