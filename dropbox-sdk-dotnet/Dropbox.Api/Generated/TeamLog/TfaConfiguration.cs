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
    /// <para>Two factor authentication configuration. Note: the enabled option is
    /// deprecated.</para>
    /// </summary>
    public class TfaConfiguration
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TfaConfiguration> Encoder = new TfaConfigurationEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TfaConfiguration> Decoder = new TfaConfigurationDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TfaConfiguration" />
        /// class.</para>
        /// </summary>
        public TfaConfiguration()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Authenticator</para>
        /// </summary>
        public bool IsAuthenticator
        {
            get
            {
                return this is Authenticator;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Authenticator, or <c>null</c>.</para>
        /// </summary>
        public Authenticator AsAuthenticator
        {
            get
            {
                return this as Authenticator;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Disabled</para>
        /// </summary>
        public bool IsDisabled
        {
            get
            {
                return this is Disabled;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Disabled, or <c>null</c>.</para>
        /// </summary>
        public Disabled AsDisabled
        {
            get
            {
                return this as Disabled;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Enabled</para>
        /// </summary>
        public bool IsEnabled
        {
            get
            {
                return this is Enabled;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Enabled, or <c>null</c>.</para>
        /// </summary>
        public Enabled AsEnabled
        {
            get
            {
                return this as Enabled;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Sms</para>
        /// </summary>
        public bool IsSms
        {
            get
            {
                return this is Sms;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Sms, or <c>null</c>.</para>
        /// </summary>
        public Sms AsSms
        {
            get
            {
                return this as Sms;
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
        /// <para>Encoder for  <see cref="TfaConfiguration" />.</para>
        /// </summary>
        private class TfaConfigurationEncoder : enc.StructEncoder<TfaConfiguration>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TfaConfiguration value, enc.IJsonWriter writer)
            {
                if (value is Authenticator)
                {
                    WriteProperty(".tag", "authenticator", writer, enc.StringEncoder.Instance);
                    Authenticator.Encoder.EncodeFields((Authenticator)value, writer);
                    return;
                }
                if (value is Disabled)
                {
                    WriteProperty(".tag", "disabled", writer, enc.StringEncoder.Instance);
                    Disabled.Encoder.EncodeFields((Disabled)value, writer);
                    return;
                }
                if (value is Enabled)
                {
                    WriteProperty(".tag", "enabled", writer, enc.StringEncoder.Instance);
                    Enabled.Encoder.EncodeFields((Enabled)value, writer);
                    return;
                }
                if (value is Sms)
                {
                    WriteProperty(".tag", "sms", writer, enc.StringEncoder.Instance);
                    Sms.Encoder.EncodeFields((Sms)value, writer);
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
        /// <para>Decoder for  <see cref="TfaConfiguration" />.</para>
        /// </summary>
        private class TfaConfigurationDecoder : enc.UnionDecoder<TfaConfiguration>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TfaConfiguration" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TfaConfiguration Create()
            {
                return new TfaConfiguration();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override TfaConfiguration Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "authenticator":
                        return Authenticator.Decoder.DecodeFields(reader);
                    case "disabled":
                        return Disabled.Decoder.DecodeFields(reader);
                    case "enabled":
                        return Enabled.Decoder.DecodeFields(reader);
                    case "sms":
                        return Sms.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The authenticator object</para>
        /// </summary>
        public sealed class Authenticator : TfaConfiguration
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Authenticator> Encoder = new AuthenticatorEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Authenticator> Decoder = new AuthenticatorDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Authenticator" />
            /// class.</para>
            /// </summary>
            private Authenticator()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Authenticator</para>
            /// </summary>
            public static readonly Authenticator Instance = new Authenticator();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Authenticator" />.</para>
            /// </summary>
            private class AuthenticatorEncoder : enc.StructEncoder<Authenticator>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Authenticator value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Authenticator" />.</para>
            /// </summary>
            private class AuthenticatorDecoder : enc.StructDecoder<Authenticator>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Authenticator" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Authenticator Create()
                {
                    return Authenticator.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The disabled object</para>
        /// </summary>
        public sealed class Disabled : TfaConfiguration
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Disabled> Encoder = new DisabledEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Disabled> Decoder = new DisabledDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Disabled" /> class.</para>
            /// </summary>
            private Disabled()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Disabled</para>
            /// </summary>
            public static readonly Disabled Instance = new Disabled();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Disabled" />.</para>
            /// </summary>
            private class DisabledEncoder : enc.StructEncoder<Disabled>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Disabled value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Disabled" />.</para>
            /// </summary>
            private class DisabledDecoder : enc.StructDecoder<Disabled>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Disabled" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Disabled Create()
                {
                    return Disabled.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The enabled object</para>
        /// </summary>
        public sealed class Enabled : TfaConfiguration
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Enabled> Encoder = new EnabledEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Enabled> Decoder = new EnabledDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Enabled" /> class.</para>
            /// </summary>
            private Enabled()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Enabled</para>
            /// </summary>
            public static readonly Enabled Instance = new Enabled();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Enabled" />.</para>
            /// </summary>
            private class EnabledEncoder : enc.StructEncoder<Enabled>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Enabled value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Enabled" />.</para>
            /// </summary>
            private class EnabledDecoder : enc.StructDecoder<Enabled>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Enabled" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Enabled Create()
                {
                    return Enabled.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The sms object</para>
        /// </summary>
        public sealed class Sms : TfaConfiguration
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Sms> Encoder = new SmsEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Sms> Decoder = new SmsDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Sms" /> class.</para>
            /// </summary>
            private Sms()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Sms</para>
            /// </summary>
            public static readonly Sms Instance = new Sms();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Sms" />.</para>
            /// </summary>
            private class SmsEncoder : enc.StructEncoder<Sms>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Sms value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Sms" />.</para>
            /// </summary>
            private class SmsDecoder : enc.StructDecoder<Sms>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Sms" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Sms Create()
                {
                    return Sms.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : TfaConfiguration
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
