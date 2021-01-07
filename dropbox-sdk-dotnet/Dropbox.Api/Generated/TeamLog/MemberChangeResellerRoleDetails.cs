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
    /// <para>Changed team member reseller role.</para>
    /// </summary>
    public class MemberChangeResellerRoleDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<MemberChangeResellerRoleDetails> Encoder = new MemberChangeResellerRoleDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<MemberChangeResellerRoleDetails> Decoder = new MemberChangeResellerRoleDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberChangeResellerRoleDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="newValue">New reseller role. This field is relevant when the reseller
        /// role is changed.</param>
        /// <param name="previousValue">Previous reseller role. This field is relevant when the
        /// reseller role is changed or when the reseller role is removed.</param>
        public MemberChangeResellerRoleDetails(ResellerRole newValue,
                                               ResellerRole previousValue)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            if (previousValue == null)
            {
                throw new sys.ArgumentNullException("previousValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="MemberChangeResellerRoleDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public MemberChangeResellerRoleDetails()
        {
        }

        /// <summary>
        /// <para>New reseller role. This field is relevant when the reseller role is
        /// changed.</para>
        /// </summary>
        public ResellerRole NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous reseller role. This field is relevant when the reseller role is
        /// changed or when the reseller role is removed.</para>
        /// </summary>
        public ResellerRole PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="MemberChangeResellerRoleDetails" />.</para>
        /// </summary>
        private class MemberChangeResellerRoleDetailsEncoder : enc.StructEncoder<MemberChangeResellerRoleDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(MemberChangeResellerRoleDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamLog.ResellerRole.Encoder);
                WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamLog.ResellerRole.Encoder);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="MemberChangeResellerRoleDetails" />.</para>
        /// </summary>
        private class MemberChangeResellerRoleDetailsDecoder : enc.StructDecoder<MemberChangeResellerRoleDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="MemberChangeResellerRoleDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override MemberChangeResellerRoleDetails Create()
            {
                return new MemberChangeResellerRoleDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(MemberChangeResellerRoleDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamLog.ResellerRole.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamLog.ResellerRole.Decoder.Decode(reader);
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
