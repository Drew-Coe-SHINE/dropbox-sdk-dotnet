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
    /// <para>The team merge request reminder shown to secondary team type object</para>
    /// </summary>
    public class TeamMergeRequestReminderShownToSecondaryTeamType
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TeamMergeRequestReminderShownToSecondaryTeamType> Encoder = new TeamMergeRequestReminderShownToSecondaryTeamTypeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TeamMergeRequestReminderShownToSecondaryTeamType> Decoder = new TeamMergeRequestReminderShownToSecondaryTeamTypeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="TeamMergeRequestReminderShownToSecondaryTeamType" /> class.</para>
        /// </summary>
        /// <param name="description">The description</param>
        public TeamMergeRequestReminderShownToSecondaryTeamType(string description)
        {
            if (description == null)
            {
                throw new sys.ArgumentNullException("description");
            }

            this.Description = description;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="TeamMergeRequestReminderShownToSecondaryTeamType" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public TeamMergeRequestReminderShownToSecondaryTeamType()
        {
        }

        /// <summary>
        /// <para>Gets the description of the team merge request reminder shown to secondary
        /// team type</para>
        /// </summary>
        public string Description { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TeamMergeRequestReminderShownToSecondaryTeamType"
        /// />.</para>
        /// </summary>
        private class TeamMergeRequestReminderShownToSecondaryTeamTypeEncoder : enc.StructEncoder<TeamMergeRequestReminderShownToSecondaryTeamType>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TeamMergeRequestReminderShownToSecondaryTeamType value, enc.IJsonWriter writer)
            {
                WriteProperty("description", value.Description, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TeamMergeRequestReminderShownToSecondaryTeamType"
        /// />.</para>
        /// </summary>
        private class TeamMergeRequestReminderShownToSecondaryTeamTypeDecoder : enc.StructDecoder<TeamMergeRequestReminderShownToSecondaryTeamType>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="TeamMergeRequestReminderShownToSecondaryTeamType" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TeamMergeRequestReminderShownToSecondaryTeamType Create()
            {
                return new TeamMergeRequestReminderShownToSecondaryTeamType();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(TeamMergeRequestReminderShownToSecondaryTeamType value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "description":
                        value.Description = enc.StringDecoder.Instance.Decode(reader);
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
