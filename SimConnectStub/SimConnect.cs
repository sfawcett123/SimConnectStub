﻿namespace SimConnectStubb
{

    public enum SIMCONNECT_SIMOBJECT_TYPE
    {
        ALL
    }

    public enum SIMCONNECT_DATATYPE
    {
        INVALID,
        INT32,
        INT64,
        FLOAT32,
        FLOAT64,
        STRING8,
        STRING32,
        STRING64,
        STRING128,
        STRING256,
        STRING260,
        STRINGV,
        INITPOSITION,
        MARKERSTATE,
        WAYPOINT,
        LATLONALT,
        XYZ
    };
    public struct SIMCONNECT_RECV
    {
        double dwSize;
        double dwVersion;
        double dwID;
    };

    public class SIMCONNECT_RECV_OPEN
    {
        double dwSize;
        double dwVersion;
        double dwID;
    };

    public struct SIMCONNECT_RECV_EXCEPTION  {    
        double dwException;
        double dwSendID;
        double dwIndex;
    };

    public struct SIMCONNECT_RECV_SYSTEM_STATE {
        public double dwRequestID;
        double dwInteger;
        float fFloat;
        public string szString;
    };

    public struct SIMCONNECT_RECV_SIMOBJECT_DATA_BYTYPE
    {
        public uint dwRequestID;
        public uint dwObjectID;
        public object[] dwData;
    }


public class SimConnect
    {
        static public int SIMCONNECT_UNUSED = 0;
        public RecvOpenEventHandler[] OnRecvOpen;
        public RecvQuitEventHandler[] OnRecvQuit;
        public RecvExceptionEventHandler[] OnRecvException;
        public RecvSystemStateEventHandler[] OnRecvSystemState;
        public RecvSimobjectDataBytypeEventHandler[] OnRecvSimobjectDataBytype ;


        public SimConnect(string v1, IntPtr intPtr, int wM_USER_SIMCONNECT, object value, int v2)
        {
        }

        public void AddToDataDefinition( Object eDef, string? parameter, string v1, SIMCONNECT_DATATYPE sTRING256, float v2, int sIMCONNECT_UNUSED)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void ReceiveMessage()
        {
            throw new NotImplementedException();
        }

        public void RegisterDataDefineStruct<T>(Object eDef)
        {
            throw new NotImplementedException();
        }

        public void RequestDataOnSimObjectType(object eRequest, object eDef, int v, SIMCONNECT_SIMOBJECT_TYPE aLL)
        {
            throw new NotImplementedException();
        }

        public void RequestSystemState(object s, string v)
        {
            throw new NotImplementedException();
        }

        public void SubscribeToSystemEvent( object x, string v)
        {
            throw new NotImplementedException();
        }

        public class RecvOpenEventHandler
        {
            public RecvOpenEventHandler(object simConnect_OnRecvOpen)
            {
            }

            public static RecvOpenEventHandler[] operator +(RecvOpenEventHandler[] x, RecvOpenEventHandler y)
            {
                return x;
            }
        }

        public class RecvQuitEventHandler
        {
            public RecvQuitEventHandler(object simConnect_OnRecvOpen)
            {
            }

            public static RecvQuitEventHandler[] operator +(RecvQuitEventHandler[] x, RecvQuitEventHandler y)
            {
                return x;
            }
        }

        public class RecvExceptionEventHandler
        {
            public RecvExceptionEventHandler(object simConnect_OnRecvOpen)
            {
            }

            public static RecvExceptionEventHandler[] operator +(RecvExceptionEventHandler[] x, RecvExceptionEventHandler y)
            {
                return x;
            }
        }

        public class RecvSystemStateEventHandler
        {
            public RecvSystemStateEventHandler(object simConnect_OnRecvOpen)
            {
            }

            public static RecvSystemStateEventHandler[] operator +(RecvSystemStateEventHandler[] x, RecvSystemStateEventHandler y)
            {
                return x;
            }
        }

        public class RecvSimobjectDataBytypeEventHandler
        {
            public RecvSimobjectDataBytypeEventHandler(object simConnect_OnRecvOpen)
            {
            }

            public static RecvSimobjectDataBytypeEventHandler[] operator +(RecvSimobjectDataBytypeEventHandler[] x, RecvSimobjectDataBytypeEventHandler y)
            {
                return x;
            }
        }
    }
}

