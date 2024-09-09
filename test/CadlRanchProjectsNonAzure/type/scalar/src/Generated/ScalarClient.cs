// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Threading;

namespace Scm._Type.Scalar
{
    // Data plane generated client.
    /// <summary> The Scalar service client. </summary>
    public partial class ScalarClient
    {
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ScalarClient. </summary>
        public ScalarClient() : this(new Uri("http://localhost:3000"), new ScalarClientOptions())
        {
        }

        /// <summary> Initializes a new instance of ScalarClient. </summary>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public ScalarClient(Uri endpoint, ScalarClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new ScalarClientOptions();

            _pipeline = ClientPipeline.Create(options, Array.Empty<PipelinePolicy>(), Array.Empty<PipelinePolicy>(), Array.Empty<PipelinePolicy>());
            _endpoint = endpoint;
        }

        private String _cachedString;
        private Boolean _cachedBoolean;
        private Unknown _cachedUnknown;
        private DecimalType _cachedDecimalType;
        private Decimal128Type _cachedDecimal128Type;
        private DecimalVerify _cachedDecimalVerify;
        private Decimal128Verify _cachedDecimal128Verify;

        /// <summary> Initializes a new instance of String. </summary>
        public virtual String GetStringClient()
        {
            return Volatile.Read(ref _cachedString) ?? Interlocked.CompareExchange(ref _cachedString, new String(_pipeline, _endpoint), null) ?? _cachedString;
        }

        /// <summary> Initializes a new instance of Boolean. </summary>
        public virtual Boolean GetBooleanClient()
        {
            return Volatile.Read(ref _cachedBoolean) ?? Interlocked.CompareExchange(ref _cachedBoolean, new Boolean(_pipeline, _endpoint), null) ?? _cachedBoolean;
        }

        /// <summary> Initializes a new instance of Unknown. </summary>
        public virtual Unknown GetUnknownClient()
        {
            return Volatile.Read(ref _cachedUnknown) ?? Interlocked.CompareExchange(ref _cachedUnknown, new Unknown(_pipeline, _endpoint), null) ?? _cachedUnknown;
        }

        /// <summary> Initializes a new instance of DecimalType. </summary>
        public virtual DecimalType GetDecimalTypeClient()
        {
            return Volatile.Read(ref _cachedDecimalType) ?? Interlocked.CompareExchange(ref _cachedDecimalType, new DecimalType(_pipeline, _endpoint), null) ?? _cachedDecimalType;
        }

        /// <summary> Initializes a new instance of Decimal128Type. </summary>
        public virtual Decimal128Type GetDecimal128TypeClient()
        {
            return Volatile.Read(ref _cachedDecimal128Type) ?? Interlocked.CompareExchange(ref _cachedDecimal128Type, new Decimal128Type(_pipeline, _endpoint), null) ?? _cachedDecimal128Type;
        }

        /// <summary> Initializes a new instance of DecimalVerify. </summary>
        public virtual DecimalVerify GetDecimalVerifyClient()
        {
            return Volatile.Read(ref _cachedDecimalVerify) ?? Interlocked.CompareExchange(ref _cachedDecimalVerify, new DecimalVerify(_pipeline, _endpoint), null) ?? _cachedDecimalVerify;
        }

        /// <summary> Initializes a new instance of Decimal128Verify. </summary>
        public virtual Decimal128Verify GetDecimal128VerifyClient()
        {
            return Volatile.Read(ref _cachedDecimal128Verify) ?? Interlocked.CompareExchange(ref _cachedDecimal128Verify, new Decimal128Verify(_pipeline, _endpoint), null) ?? _cachedDecimal128Verify;
        }
    }
}
