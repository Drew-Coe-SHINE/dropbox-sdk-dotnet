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
    /// <para>The lock file result object</para>
    /// </summary>
    public class LockFileResult
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LockFileResult> Encoder = new LockFileResultEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LockFileResult> Decoder = new LockFileResultDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LockFileResult" /> class.</para>
        /// </summary>
        /// <param name="metadata">Metadata of the file.</param>
        /// <param name="lock">The file lock state after the operation.</param>
        public LockFileResult(Metadata metadata,
                              FileLock @lock)
        {
            if (metadata == null)
            {
                throw new sys.ArgumentNullException("metadata");
            }

            if (@lock == null)
            {
                throw new sys.ArgumentNullException("@lock");
            }

            this.Metadata = metadata;
            this.Lock = @lock;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LockFileResult" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public LockFileResult()
        {
        }

        /// <summary>
        /// <para>Metadata of the file.</para>
        /// </summary>
        public Metadata Metadata { get; protected set; }

        /// <summary>
        /// <para>The file lock state after the operation.</para>
        /// </summary>
        public FileLock Lock { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LockFileResult" />.</para>
        /// </summary>
        private class LockFileResultEncoder : enc.StructEncoder<LockFileResult>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LockFileResult value, enc.IJsonWriter writer)
            {
                WriteProperty("metadata", value.Metadata, writer, global::Dropbox.Api.Files.Metadata.Encoder);
                WriteProperty("lock", value.Lock, writer, global::Dropbox.Api.Files.FileLock.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LockFileResult" />.</para>
        /// </summary>
        private class LockFileResultDecoder : enc.StructDecoder<LockFileResult>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LockFileResult" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LockFileResult Create()
            {
                return new LockFileResult();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(LockFileResult value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "metadata":
                        value.Metadata = global::Dropbox.Api.Files.Metadata.Decoder.Decode(reader);
                        break;
                    case "lock":
                        value.Lock = global::Dropbox.Api.Files.FileLock.Decoder.Decode(reader);
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
