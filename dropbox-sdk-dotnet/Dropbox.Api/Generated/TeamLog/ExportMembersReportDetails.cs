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
    /// <para>Created member data report.</para>
    /// </summary>
    public class ExportMembersReportDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ExportMembersReportDetails> Encoder = new ExportMembersReportDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ExportMembersReportDetails> Decoder = new ExportMembersReportDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ExportMembersReportDetails" />
        /// class.</para>
        /// </summary>
        public ExportMembersReportDetails()
        {
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ExportMembersReportDetails" />.</para>
        /// </summary>
        private class ExportMembersReportDetailsEncoder : enc.StructEncoder<ExportMembersReportDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ExportMembersReportDetails value, enc.IJsonWriter writer)
            {
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ExportMembersReportDetails" />.</para>
        /// </summary>
        private class ExportMembersReportDetailsDecoder : enc.StructDecoder<ExportMembersReportDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ExportMembersReportDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ExportMembersReportDetails Create()
            {
                return new ExportMembersReportDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ExportMembersReportDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
