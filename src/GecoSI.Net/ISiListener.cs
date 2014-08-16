using System;
using GecoSI.Net.Dataframe;

namespace GecoSI.Net
{
    public interface ISiListener
    {
        void HandleEcard(ISiDataFrame dataFrame);

        void Notify(CommStatus status);

        void Notify(CommStatus errorStatus, String errorMessage);
    }
}