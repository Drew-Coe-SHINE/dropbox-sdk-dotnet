// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The space limits status object</para>
    /// </summary>
    public class SpaceLimitsStatus
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SpaceLimitsStatus> Encoder = new SpaceLimitsStatusEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SpaceLimitsStatus> Decoder = new SpaceLimitsStatusDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SpaceLimitsStatus" />
        /// class.</para>
        /// </summary>
        public SpaceLimitsStatus()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NearQuota</para>
        /// </summary>
        public bool IsNearQuota
        {
            get
            {
                return this is NearQuota;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NearQuota, or <c>null</c>.</para>
        /// </summary>
        public NearQuota AsNearQuota
        {
            get
            {
                return this as NearQuota;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is OverQuota</para>
        /// </summary>
        public bool IsOverQuota
        {
            get
            {
                return this is OverQuota;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a OverQuota, or <c>null</c>.</para>
        /// </summary>
        public OverQuota AsOverQuota
        {
            get
            {
                return this as OverQuota;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is WithinQuota</para>
        /// </summary>
        public bool IsWithinQuota
        {
            get
            {
                return this is WithinQuota;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a WithinQuota, or <c>null</c>.</para>
        /// </summary>
        public WithinQuota AsWithinQuota
        {
            get
            {
                return this as WithinQuota;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SpaceLimitsStatus" />.</para>
        /// </summary>
        private class SpaceLimitsStatusEncoder : enc.StructEncoder<SpaceLimitsStatus>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SpaceLimitsStatus value, enc.IJsonWriter writer)
            {
                if (value is NearQuota)
                {
                    WriteProperty(".tag", "near_quota", writer, enc.StringEncoder.Instance);
                    NearQuota.Encoder.EncodeFields((NearQuota)value, writer);
                    return;
                }
                if (value is OverQuota)
                {
                    WriteProperty(".tag", "over_quota", writer, enc.StringEncoder.Instance);
                    OverQuota.Encoder.EncodeFields((OverQuota)value, writer);
                    return;
                }
                if (value is WithinQuota)
                {
                    WriteProperty(".tag", "within_quota", writer, enc.StringEncoder.Instance);
                    WithinQuota.Encoder.EncodeFields((WithinQuota)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SpaceLimitsStatus" />.</para>
        /// </summary>
        private class SpaceLimitsStatusDecoder : enc.UnionDecoder<SpaceLimitsStatus>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SpaceLimitsStatus" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SpaceLimitsStatus Create()
            {
                return new SpaceLimitsStatus();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override SpaceLimitsStatus Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "near_quota":
                        return NearQuota.Decoder.DecodeFields(reader);
                    case "over_quota":
                        return OverQuota.Decoder.DecodeFields(reader);
                    case "within_quota":
                        return WithinQuota.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The near quota object</para>
        /// </summary>
        public sealed class NearQuota : SpaceLimitsStatus
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NearQuota> Encoder = new NearQuotaEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NearQuota> Decoder = new NearQuotaDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NearQuota" /> class.</para>
            /// </summary>
            private NearQuota()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NearQuota</para>
            /// </summary>
            public static readonly NearQuota Instance = new NearQuota();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NearQuota" />.</para>
            /// </summary>
            private class NearQuotaEncoder : enc.StructEncoder<NearQuota>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NearQuota value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NearQuota" />.</para>
            /// </summary>
            private class NearQuotaDecoder : enc.StructDecoder<NearQuota>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NearQuota" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NearQuota Create()
                {
                    return NearQuota.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The over quota object</para>
        /// </summary>
        public sealed class OverQuota : SpaceLimitsStatus
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<OverQuota> Encoder = new OverQuotaEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<OverQuota> Decoder = new OverQuotaDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="OverQuota" /> class.</para>
            /// </summary>
            private OverQuota()
            {
            }

            /// <summary>
            /// <para>A singleton instance of OverQuota</para>
            /// </summary>
            public static readonly OverQuota Instance = new OverQuota();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="OverQuota" />.</para>
            /// </summary>
            private class OverQuotaEncoder : enc.StructEncoder<OverQuota>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(OverQuota value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="OverQuota" />.</para>
            /// </summary>
            private class OverQuotaDecoder : enc.StructDecoder<OverQuota>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="OverQuota" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override OverQuota Create()
                {
                    return OverQuota.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The within quota object</para>
        /// </summary>
        public sealed class WithinQuota : SpaceLimitsStatus
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<WithinQuota> Encoder = new WithinQuotaEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<WithinQuota> Decoder = new WithinQuotaDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="WithinQuota" />
            /// class.</para>
            /// </summary>
            private WithinQuota()
            {
            }

            /// <summary>
            /// <para>A singleton instance of WithinQuota</para>
            /// </summary>
            public static readonly WithinQuota Instance = new WithinQuota();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="WithinQuota" />.</para>
            /// </summary>
            private class WithinQuotaEncoder : enc.StructEncoder<WithinQuota>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(WithinQuota value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="WithinQuota" />.</para>
            /// </summary>
            private class WithinQuotaDecoder : enc.StructDecoder<WithinQuota>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="WithinQuota" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override WithinQuota Create()
                {
                    return WithinQuota.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : SpaceLimitsStatus
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
