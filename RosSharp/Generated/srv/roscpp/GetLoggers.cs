//----------------------------------------------------------------
// <auto-generated>
//     This code was generated by the GenMsg. Version: 0.1.0.0
//     Don't change it manually.
//     2012-04-29T23:10:50+09:00
// </auto-generated>
//----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RosSharp.Message;
using RosSharp.Service;
namespace RosSharp.roscpp
{
    public class GetLoggers : ServiceBase<GetLoggers.Request,GetLoggers.Response>
    {
        public GetLoggers()
        {
        }
        public GetLoggers(Func<Request,Response> action)
            :base(action)
        {
        }
        public override string ServiceType
        {
            get { return "roscpp/GetLoggers"; }
        }
        public override string Md5Sum
        {
            get { return "32e97e85527d4678a8f9279894bb64b0"; }
        }
        public override string ServiceDefinition
        {
            get { return "---\nLogger[] loggers"; }
        }
    public class Request : IMessage
    {
        public Request()
        {
        }
        public Request(BinaryReader br)
        {
            Deserialize(br);
        }
        public string MessageType
        {
            get { return "GetLoggersRequest"; }
        }
        public string Md5Sum
        {
            get { return "d41d8cd98f00b204e9800998ecf8427e"; }
        }
        public string MessageDefinition
        {
            get { return ""; }
        }
        public void Serialize(BinaryWriter bw)
        {
        }
        public void Deserialize(BinaryReader br)
        {
        }
        public int SerializeLength
        {
            get { return 0; }
        }
        public bool Equals(Request other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return true;
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Request)) return false;
            return Equals((Request)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;

                return result;
            }
        }
    }
    public class Response : IMessage
    {
        public Response()
        {
            loggers = new List<Logger>();
        }
        public Response(BinaryReader br)
        {
            Deserialize(br);
        }
        public List<Logger> loggers { get; set; }
        public string MessageType
        {
            get { return "GetLoggersResponse"; }
        }
        public string Md5Sum
        {
            get { return "32e97e85527d4678a8f9279894bb64b0"; }
        }
        public string MessageDefinition
        {
            get { return "Logger[] loggers"; }
        }
        public void Serialize(BinaryWriter bw)
        {
            bw.Write(loggers.Count); for(int i=0; i<loggers.Count; i++) { loggers[i].Serialize(bw);}
        }
        public void Deserialize(BinaryReader br)
        {
            loggers = new List<Logger>(br.ReadInt32()); for(int i=0; i<loggers.Count; i++) { loggers[i] = new Logger(br);}
        }
        public int SerializeLength
        {
            get { return 4 + loggers.Sum(x => x.SerializeLength); }
        }
        public bool Equals(Response other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.loggers.Equals(loggers);
        }
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Response)) return false;
            return Equals((Response)obj);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int result = 0;
                result = (result * 397) ^ loggers.GetHashCode();
                return result;
            }
        }
    }
    }
}