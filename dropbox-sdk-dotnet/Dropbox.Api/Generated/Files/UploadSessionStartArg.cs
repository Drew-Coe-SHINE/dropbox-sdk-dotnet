// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The upload session start arg object</para>
    /// </summary>
    public class UploadSessionStartArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UploadSessionStartArg> Encoder = new UploadSessionStartArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UploadSessionStartArg> Decoder = new UploadSessionStartArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionStartArg" />
        /// class.</para>
        /// </summary>
        /// <param name="close">If true, the current session will be closed, at which point you
        /// won't be able to call <see
        /// cref="Dropbox.Api.Files.Routes.FilesUserRoutes.UploadSessionAppendV2Async" />
        /// anymore with the current session.</param>
        /// <param name="sessionType">Type of upload session you want to start. If not
        /// specified, default is <see cref="Dropbox.Api.Files.UploadSessionType.Sequential"
        /// />.</param>
        public UploadSessionStartArg(bool close = false,
                                     UploadSessionType sessionType = null)
        {
            this.Close = close;
            this.SessionType = sessionType;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadSessionStartArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public UploadSessionStartArg()
        {
            this.Close = false;
        }

        /// <summary>
        /// <para>If true, the current session will be closed, at which point you won't be able
        /// to call <see
        /// cref="Dropbox.Api.Files.Routes.FilesUserRoutes.UploadSessionAppendV2Async" />
        /// anymore with the current session.</para>
        /// </summary>
        public bool Close { get; protected set; }

        /// <summary>
        /// <para>Type of upload session you want to start. If not specified, default is <see
        /// cref="Dropbox.Api.Files.UploadSessionType.Sequential" />.</para>
        /// </summary>
        public UploadSessionType SessionType { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UploadSessionStartArg" />.</para>
        /// </summary>
        private class UploadSessionStartArgEncoder : enc.StructEncoder<UploadSessionStartArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UploadSessionStartArg value, enc.IJsonWriter writer)
            {
                WriteProperty("close", value.Close, writer, enc.BooleanEncoder.Instance);
                if (value.SessionType != null)
                {
                    WriteProperty("session_type", value.SessionType, writer, global::Dropbox.Api.Files.UploadSessionType.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UploadSessionStartArg" />.</para>
        /// </summary>
        private class UploadSessionStartArgDecoder : enc.StructDecoder<UploadSessionStartArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UploadSessionStartArg"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UploadSessionStartArg Create()
            {
                return new UploadSessionStartArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(UploadSessionStartArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "close":
                        value.Close = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "session_type":
                        value.SessionType = global::Dropbox.Api.Files.UploadSessionType.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
