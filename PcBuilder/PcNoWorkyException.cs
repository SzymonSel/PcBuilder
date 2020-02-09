using System;
using System.Runtime.Serialization;

namespace PcBuilder {
    [Serializable]
    internal class PcNoWorkyException : Exception {
        public PcNoWorkyException() {
        }

        public PcNoWorkyException(string message) : base(message) {
        }

        public PcNoWorkyException(string message, Exception innerException) : base(message, innerException) {
        }

        protected PcNoWorkyException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}