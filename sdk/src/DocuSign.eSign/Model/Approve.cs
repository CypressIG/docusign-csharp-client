/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// Approve
    /// </summary>
    [DataContract]
    public partial class Approve :  IEquatable<Approve>, IValidatableObject
    {
        public Approve()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Approve" /> class.
        /// </summary>
        /// <param name="AnchorCaseSensitive">When set to **true**, the anchor string does not consider case when matching strings in the document. The default value is **true**..</param>
        /// <param name="AnchorHorizontalAlignment">Specifies the alignment of anchor tabs with anchor strings. Possible values are **left** or **right**. The default value is **left**..</param>
        /// <param name="AnchorIgnoreIfNotPresent">When set to **true**, this tab is ignored if anchorString is not found in the document..</param>
        /// <param name="AnchorMatchWholeWord">When set to **true**, the anchor string in this tab matches whole words only (strings embedded in other strings are ignored.) The default value is **true**..</param>
        /// <param name="AnchorString">Anchor text information for a radio button..</param>
        /// <param name="AnchorUnits">Specifies units of the X and Y offset. Units could be pixels, millimeters, centimeters, or inches..</param>
        /// <param name="AnchorXOffset">Specifies the X axis location of the tab, in anchorUnits, relative to the anchorString..</param>
        /// <param name="AnchorYOffset">Specifies the Y axis location of the tab, in anchorUnits, relative to the anchorString..</param>
        /// <param name="Bold">When set to **true**, the information in the tab is bold..</param>
        /// <param name="ButtonText"> Specifies the approval text displayed in the tab. .</param>
        /// <param name="ConditionalParentLabel">For conditional fields this is the TabLabel of the parent tab that controls this tab&#39;s visibility..</param>
        /// <param name="ConditionalParentValue">For conditional fields, this is the value of the parent tab that controls the tab&#39;s visibility.  If the parent tab is a Checkbox, Radio button, Optional Signature, or Optional Initial use \&quot;on\&quot; as the value to show that the parent tab is active. .</param>
        /// <param name="CustomTabId">The DocuSign generated custom tab ID for the custom tab to be applied. This can only be used when adding new tabs for a recipient. When used, the new tab inherits all the custom tab properties..</param>
        /// <param name="DocumentId">Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute..</param>
        /// <param name="ErrorDetails">ErrorDetails.</param>
        /// <param name="Font">The font to be used for the tab value. Supported Fonts: Arial, Arial, ArialNarrow, Calibri, CourierNew, Garamond, Georgia, Helvetica,   LucidaConsole, Tahoma, TimesNewRoman, Trebuchet, Verdana, MSGothic, MSMincho, Default..</param>
        /// <param name="FontColor">The font color used for the information in the tab.  Possible values are: Black, BrightBlue, BrightRed, DarkGreen, DarkRed, Gold, Green, NavyBlue, Purple, or White..</param>
        /// <param name="FontSize">The font size used for the information in the tab.  Possible values are: Size7, Size8, Size9, Size10, Size11, Size12, Size14, Size16, Size18, Size20, Size22, Size24, Size26, Size28, Size36, Size48, or Size72..</param>
        /// <param name="Height">Height of the tab in pixels..</param>
        /// <param name="Italic">When set to **true**, the information in the tab is italic..</param>
        /// <param name="MergeField">MergeField.</param>
        /// <param name="PageNumber">Specifies the page number on which the tab is located..</param>
        /// <param name="RecipientId">Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document..</param>
        /// <param name="Status">Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later..</param>
        /// <param name="TabId">The unique identifier for the tab. The tabid can be retrieved with the [ML:GET call].     .</param>
        /// <param name="TabLabel">The label string associated with the tab..</param>
        /// <param name="TabOrder">.</param>
        /// <param name="TemplateLocked">When set to **true**, the sender cannot change any attributes of the recipient. Used only when working with template recipients. .</param>
        /// <param name="TemplateRequired">When set to **true**, the sender may not remove the recipient. Used only when working with template recipients..</param>
        /// <param name="Underline">When set to **true**, the information in the tab is underlined..</param>
        /// <param name="Width">Width of the tab in pixels..</param>
        /// <param name="XPosition">This indicates the horizontal offset of the object on the page. DocuSign uses 72 DPI when determining position..</param>
        /// <param name="YPosition">This indicates the vertical offset of the object on the page. DocuSign uses 72 DPI when determining position..</param>
        public Approve(string AnchorCaseSensitive = default(string), string AnchorHorizontalAlignment = default(string), string AnchorIgnoreIfNotPresent = default(string), string AnchorMatchWholeWord = default(string), string AnchorString = default(string), string AnchorUnits = default(string), string AnchorXOffset = default(string), string AnchorYOffset = default(string), string Bold = default(string), string ButtonText = default(string), string ConditionalParentLabel = default(string), string ConditionalParentValue = default(string), string CustomTabId = default(string), string DocumentId = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string Font = default(string), string FontColor = default(string), string FontSize = default(string), int? Height = default(int?), string Italic = default(string), MergeField MergeField = default(MergeField), string PageNumber = default(string), string RecipientId = default(string), string Status = default(string), string TabId = default(string), string TabLabel = default(string), string TabOrder = default(string), string TemplateLocked = default(string), string TemplateRequired = default(string), string Underline = default(string), int? Width = default(int?), string XPosition = default(string), string YPosition = default(string))
        {
            this.AnchorCaseSensitive = AnchorCaseSensitive;
            this.AnchorHorizontalAlignment = AnchorHorizontalAlignment;
            this.AnchorIgnoreIfNotPresent = AnchorIgnoreIfNotPresent;
            this.AnchorMatchWholeWord = AnchorMatchWholeWord;
            this.AnchorString = AnchorString;
            this.AnchorUnits = AnchorUnits;
            this.AnchorXOffset = AnchorXOffset;
            this.AnchorYOffset = AnchorYOffset;
            this.Bold = Bold;
            this.ButtonText = ButtonText;
            this.ConditionalParentLabel = ConditionalParentLabel;
            this.ConditionalParentValue = ConditionalParentValue;
            this.CustomTabId = CustomTabId;
            this.DocumentId = DocumentId;
            this.ErrorDetails = ErrorDetails;
            this.Font = Font;
            this.FontColor = FontColor;
            this.FontSize = FontSize;
            this.Height = Height;
            this.Italic = Italic;
            this.MergeField = MergeField;
            this.PageNumber = PageNumber;
            this.RecipientId = RecipientId;
            this.Status = Status;
            this.TabId = TabId;
            this.TabLabel = TabLabel;
            this.TabOrder = TabOrder;
            this.TemplateLocked = TemplateLocked;
            this.TemplateRequired = TemplateRequired;
            this.Underline = Underline;
            this.Width = Width;
            this.XPosition = XPosition;
            this.YPosition = YPosition;
        }
        
        /// <summary>
        /// When set to **true**, the anchor string does not consider case when matching strings in the document. The default value is **true**.
        /// </summary>
        /// <value>When set to **true**, the anchor string does not consider case when matching strings in the document. The default value is **true**.</value>
        [DataMember(Name="anchorCaseSensitive", EmitDefaultValue=false)]
        public string AnchorCaseSensitive { get; set; }
        /// <summary>
        /// Specifies the alignment of anchor tabs with anchor strings. Possible values are **left** or **right**. The default value is **left**.
        /// </summary>
        /// <value>Specifies the alignment of anchor tabs with anchor strings. Possible values are **left** or **right**. The default value is **left**.</value>
        [DataMember(Name="anchorHorizontalAlignment", EmitDefaultValue=false)]
        public string AnchorHorizontalAlignment { get; set; }
        /// <summary>
        /// When set to **true**, this tab is ignored if anchorString is not found in the document.
        /// </summary>
        /// <value>When set to **true**, this tab is ignored if anchorString is not found in the document.</value>
        [DataMember(Name="anchorIgnoreIfNotPresent", EmitDefaultValue=false)]
        public string AnchorIgnoreIfNotPresent { get; set; }
        /// <summary>
        /// When set to **true**, the anchor string in this tab matches whole words only (strings embedded in other strings are ignored.) The default value is **true**.
        /// </summary>
        /// <value>When set to **true**, the anchor string in this tab matches whole words only (strings embedded in other strings are ignored.) The default value is **true**.</value>
        [DataMember(Name="anchorMatchWholeWord", EmitDefaultValue=false)]
        public string AnchorMatchWholeWord { get; set; }
        /// <summary>
        /// Anchor text information for a radio button.
        /// </summary>
        /// <value>Anchor text information for a radio button.</value>
        [DataMember(Name="anchorString", EmitDefaultValue=false)]
        public string AnchorString { get; set; }
        /// <summary>
        /// Specifies units of the X and Y offset. Units could be pixels, millimeters, centimeters, or inches.
        /// </summary>
        /// <value>Specifies units of the X and Y offset. Units could be pixels, millimeters, centimeters, or inches.</value>
        [DataMember(Name="anchorUnits", EmitDefaultValue=false)]
        public string AnchorUnits { get; set; }
        /// <summary>
        /// Specifies the X axis location of the tab, in anchorUnits, relative to the anchorString.
        /// </summary>
        /// <value>Specifies the X axis location of the tab, in anchorUnits, relative to the anchorString.</value>
        [DataMember(Name="anchorXOffset", EmitDefaultValue=false)]
        public string AnchorXOffset { get; set; }
        /// <summary>
        /// Specifies the Y axis location of the tab, in anchorUnits, relative to the anchorString.
        /// </summary>
        /// <value>Specifies the Y axis location of the tab, in anchorUnits, relative to the anchorString.</value>
        [DataMember(Name="anchorYOffset", EmitDefaultValue=false)]
        public string AnchorYOffset { get; set; }
        /// <summary>
        /// When set to **true**, the information in the tab is bold.
        /// </summary>
        /// <value>When set to **true**, the information in the tab is bold.</value>
        [DataMember(Name="bold", EmitDefaultValue=false)]
        public string Bold { get; set; }
        /// <summary>
        ///  Specifies the approval text displayed in the tab. 
        /// </summary>
        /// <value> Specifies the approval text displayed in the tab. </value>
        [DataMember(Name="buttonText", EmitDefaultValue=false)]
        public string ButtonText { get; set; }
        /// <summary>
        /// For conditional fields this is the TabLabel of the parent tab that controls this tab&#39;s visibility.
        /// </summary>
        /// <value>For conditional fields this is the TabLabel of the parent tab that controls this tab&#39;s visibility.</value>
        [DataMember(Name="conditionalParentLabel", EmitDefaultValue=false)]
        public string ConditionalParentLabel { get; set; }
        /// <summary>
        /// For conditional fields, this is the value of the parent tab that controls the tab&#39;s visibility.  If the parent tab is a Checkbox, Radio button, Optional Signature, or Optional Initial use \&quot;on\&quot; as the value to show that the parent tab is active. 
        /// </summary>
        /// <value>For conditional fields, this is the value of the parent tab that controls the tab&#39;s visibility.  If the parent tab is a Checkbox, Radio button, Optional Signature, or Optional Initial use \&quot;on\&quot; as the value to show that the parent tab is active. </value>
        [DataMember(Name="conditionalParentValue", EmitDefaultValue=false)]
        public string ConditionalParentValue { get; set; }
        /// <summary>
        /// The DocuSign generated custom tab ID for the custom tab to be applied. This can only be used when adding new tabs for a recipient. When used, the new tab inherits all the custom tab properties.
        /// </summary>
        /// <value>The DocuSign generated custom tab ID for the custom tab to be applied. This can only be used when adding new tabs for a recipient. When used, the new tab inherits all the custom tab properties.</value>
        [DataMember(Name="customTabId", EmitDefaultValue=false)]
        public string CustomTabId { get; set; }
        /// <summary>
        /// Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute.
        /// </summary>
        /// <value>Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute.</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// The font to be used for the tab value. Supported Fonts: Arial, Arial, ArialNarrow, Calibri, CourierNew, Garamond, Georgia, Helvetica,   LucidaConsole, Tahoma, TimesNewRoman, Trebuchet, Verdana, MSGothic, MSMincho, Default.
        /// </summary>
        /// <value>The font to be used for the tab value. Supported Fonts: Arial, Arial, ArialNarrow, Calibri, CourierNew, Garamond, Georgia, Helvetica,   LucidaConsole, Tahoma, TimesNewRoman, Trebuchet, Verdana, MSGothic, MSMincho, Default.</value>
        [DataMember(Name="font", EmitDefaultValue=false)]
        public string Font { get; set; }
        /// <summary>
        /// The font color used for the information in the tab.  Possible values are: Black, BrightBlue, BrightRed, DarkGreen, DarkRed, Gold, Green, NavyBlue, Purple, or White.
        /// </summary>
        /// <value>The font color used for the information in the tab.  Possible values are: Black, BrightBlue, BrightRed, DarkGreen, DarkRed, Gold, Green, NavyBlue, Purple, or White.</value>
        [DataMember(Name="fontColor", EmitDefaultValue=false)]
        public string FontColor { get; set; }
        /// <summary>
        /// The font size used for the information in the tab.  Possible values are: Size7, Size8, Size9, Size10, Size11, Size12, Size14, Size16, Size18, Size20, Size22, Size24, Size26, Size28, Size36, Size48, or Size72.
        /// </summary>
        /// <value>The font size used for the information in the tab.  Possible values are: Size7, Size8, Size9, Size10, Size11, Size12, Size14, Size16, Size18, Size20, Size22, Size24, Size26, Size28, Size36, Size48, or Size72.</value>
        [DataMember(Name="fontSize", EmitDefaultValue=false)]
        public string FontSize { get; set; }
        /// <summary>
        /// Height of the tab in pixels.
        /// </summary>
        /// <value>Height of the tab in pixels.</value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public int? Height { get; set; }
        /// <summary>
        /// When set to **true**, the information in the tab is italic.
        /// </summary>
        /// <value>When set to **true**, the information in the tab is italic.</value>
        [DataMember(Name="italic", EmitDefaultValue=false)]
        public string Italic { get; set; }
        /// <summary>
        /// Gets or Sets MergeField
        /// </summary>
        [DataMember(Name="mergeField", EmitDefaultValue=false)]
        public MergeField MergeField { get; set; }
        /// <summary>
        /// Specifies the page number on which the tab is located.
        /// </summary>
        /// <value>Specifies the page number on which the tab is located.</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public string PageNumber { get; set; }
        /// <summary>
        /// Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.
        /// </summary>
        /// <value>Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.</value>
        [DataMember(Name="recipientId", EmitDefaultValue=false)]
        public string RecipientId { get; set; }
        /// <summary>
        /// Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.
        /// </summary>
        /// <value>Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// The unique identifier for the tab. The tabid can be retrieved with the [ML:GET call].     
        /// </summary>
        /// <value>The unique identifier for the tab. The tabid can be retrieved with the [ML:GET call].     </value>
        [DataMember(Name="tabId", EmitDefaultValue=false)]
        public string TabId { get; set; }
        /// <summary>
        /// The label string associated with the tab.
        /// </summary>
        /// <value>The label string associated with the tab.</value>
        [DataMember(Name="tabLabel", EmitDefaultValue=false)]
        public string TabLabel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="tabOrder", EmitDefaultValue=false)]
        public string TabOrder { get; set; }
        /// <summary>
        /// When set to **true**, the sender cannot change any attributes of the recipient. Used only when working with template recipients. 
        /// </summary>
        /// <value>When set to **true**, the sender cannot change any attributes of the recipient. Used only when working with template recipients. </value>
        [DataMember(Name="templateLocked", EmitDefaultValue=false)]
        public string TemplateLocked { get; set; }
        /// <summary>
        /// When set to **true**, the sender may not remove the recipient. Used only when working with template recipients.
        /// </summary>
        /// <value>When set to **true**, the sender may not remove the recipient. Used only when working with template recipients.</value>
        [DataMember(Name="templateRequired", EmitDefaultValue=false)]
        public string TemplateRequired { get; set; }
        /// <summary>
        /// When set to **true**, the information in the tab is underlined.
        /// </summary>
        /// <value>When set to **true**, the information in the tab is underlined.</value>
        [DataMember(Name="underline", EmitDefaultValue=false)]
        public string Underline { get; set; }
        /// <summary>
        /// Width of the tab in pixels.
        /// </summary>
        /// <value>Width of the tab in pixels.</value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public int? Width { get; set; }
        /// <summary>
        /// This indicates the horizontal offset of the object on the page. DocuSign uses 72 DPI when determining position.
        /// </summary>
        /// <value>This indicates the horizontal offset of the object on the page. DocuSign uses 72 DPI when determining position.</value>
        [DataMember(Name="xPosition", EmitDefaultValue=false)]
        public string XPosition { get; set; }
        /// <summary>
        /// This indicates the vertical offset of the object on the page. DocuSign uses 72 DPI when determining position.
        /// </summary>
        /// <value>This indicates the vertical offset of the object on the page. DocuSign uses 72 DPI when determining position.</value>
        [DataMember(Name="yPosition", EmitDefaultValue=false)]
        public string YPosition { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Approve {\n");
            sb.Append("  AnchorCaseSensitive: ").Append(AnchorCaseSensitive).Append("\n");
            sb.Append("  AnchorHorizontalAlignment: ").Append(AnchorHorizontalAlignment).Append("\n");
            sb.Append("  AnchorIgnoreIfNotPresent: ").Append(AnchorIgnoreIfNotPresent).Append("\n");
            sb.Append("  AnchorMatchWholeWord: ").Append(AnchorMatchWholeWord).Append("\n");
            sb.Append("  AnchorString: ").Append(AnchorString).Append("\n");
            sb.Append("  AnchorUnits: ").Append(AnchorUnits).Append("\n");
            sb.Append("  AnchorXOffset: ").Append(AnchorXOffset).Append("\n");
            sb.Append("  AnchorYOffset: ").Append(AnchorYOffset).Append("\n");
            sb.Append("  Bold: ").Append(Bold).Append("\n");
            sb.Append("  ButtonText: ").Append(ButtonText).Append("\n");
            sb.Append("  ConditionalParentLabel: ").Append(ConditionalParentLabel).Append("\n");
            sb.Append("  ConditionalParentValue: ").Append(ConditionalParentValue).Append("\n");
            sb.Append("  CustomTabId: ").Append(CustomTabId).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Font: ").Append(Font).Append("\n");
            sb.Append("  FontColor: ").Append(FontColor).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Italic: ").Append(Italic).Append("\n");
            sb.Append("  MergeField: ").Append(MergeField).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TabId: ").Append(TabId).Append("\n");
            sb.Append("  TabLabel: ").Append(TabLabel).Append("\n");
            sb.Append("  TabOrder: ").Append(TabOrder).Append("\n");
            sb.Append("  TemplateLocked: ").Append(TemplateLocked).Append("\n");
            sb.Append("  TemplateRequired: ").Append(TemplateRequired).Append("\n");
            sb.Append("  Underline: ").Append(Underline).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  XPosition: ").Append(XPosition).Append("\n");
            sb.Append("  YPosition: ").Append(YPosition).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Approve);
        }

        /// <summary>
        /// Returns true if Approve instances are equal
        /// </summary>
        /// <param name="other">Instance of Approve to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Approve other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AnchorCaseSensitive == other.AnchorCaseSensitive ||
                    this.AnchorCaseSensitive != null &&
                    this.AnchorCaseSensitive.Equals(other.AnchorCaseSensitive)
                ) && 
                (
                    this.AnchorHorizontalAlignment == other.AnchorHorizontalAlignment ||
                    this.AnchorHorizontalAlignment != null &&
                    this.AnchorHorizontalAlignment.Equals(other.AnchorHorizontalAlignment)
                ) && 
                (
                    this.AnchorIgnoreIfNotPresent == other.AnchorIgnoreIfNotPresent ||
                    this.AnchorIgnoreIfNotPresent != null &&
                    this.AnchorIgnoreIfNotPresent.Equals(other.AnchorIgnoreIfNotPresent)
                ) && 
                (
                    this.AnchorMatchWholeWord == other.AnchorMatchWholeWord ||
                    this.AnchorMatchWholeWord != null &&
                    this.AnchorMatchWholeWord.Equals(other.AnchorMatchWholeWord)
                ) && 
                (
                    this.AnchorString == other.AnchorString ||
                    this.AnchorString != null &&
                    this.AnchorString.Equals(other.AnchorString)
                ) && 
                (
                    this.AnchorUnits == other.AnchorUnits ||
                    this.AnchorUnits != null &&
                    this.AnchorUnits.Equals(other.AnchorUnits)
                ) && 
                (
                    this.AnchorXOffset == other.AnchorXOffset ||
                    this.AnchorXOffset != null &&
                    this.AnchorXOffset.Equals(other.AnchorXOffset)
                ) && 
                (
                    this.AnchorYOffset == other.AnchorYOffset ||
                    this.AnchorYOffset != null &&
                    this.AnchorYOffset.Equals(other.AnchorYOffset)
                ) && 
                (
                    this.Bold == other.Bold ||
                    this.Bold != null &&
                    this.Bold.Equals(other.Bold)
                ) && 
                (
                    this.ButtonText == other.ButtonText ||
                    this.ButtonText != null &&
                    this.ButtonText.Equals(other.ButtonText)
                ) && 
                (
                    this.ConditionalParentLabel == other.ConditionalParentLabel ||
                    this.ConditionalParentLabel != null &&
                    this.ConditionalParentLabel.Equals(other.ConditionalParentLabel)
                ) && 
                (
                    this.ConditionalParentValue == other.ConditionalParentValue ||
                    this.ConditionalParentValue != null &&
                    this.ConditionalParentValue.Equals(other.ConditionalParentValue)
                ) && 
                (
                    this.CustomTabId == other.CustomTabId ||
                    this.CustomTabId != null &&
                    this.CustomTabId.Equals(other.CustomTabId)
                ) && 
                (
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.Font == other.Font ||
                    this.Font != null &&
                    this.Font.Equals(other.Font)
                ) && 
                (
                    this.FontColor == other.FontColor ||
                    this.FontColor != null &&
                    this.FontColor.Equals(other.FontColor)
                ) && 
                (
                    this.FontSize == other.FontSize ||
                    this.FontSize != null &&
                    this.FontSize.Equals(other.FontSize)
                ) && 
                (
                    this.Height == other.Height ||
                    this.Height != null &&
                    this.Height.Equals(other.Height)
                ) && 
                (
                    this.Italic == other.Italic ||
                    this.Italic != null &&
                    this.Italic.Equals(other.Italic)
                ) && 
                (
                    this.MergeField == other.MergeField ||
                    this.MergeField != null &&
                    this.MergeField.Equals(other.MergeField)
                ) && 
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) && 
                (
                    this.RecipientId == other.RecipientId ||
                    this.RecipientId != null &&
                    this.RecipientId.Equals(other.RecipientId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.TabId == other.TabId ||
                    this.TabId != null &&
                    this.TabId.Equals(other.TabId)
                ) && 
                (
                    this.TabLabel == other.TabLabel ||
                    this.TabLabel != null &&
                    this.TabLabel.Equals(other.TabLabel)
                ) && 
                (
                    this.TabOrder == other.TabOrder ||
                    this.TabOrder != null &&
                    this.TabOrder.Equals(other.TabOrder)
                ) && 
                (
                    this.TemplateLocked == other.TemplateLocked ||
                    this.TemplateLocked != null &&
                    this.TemplateLocked.Equals(other.TemplateLocked)
                ) && 
                (
                    this.TemplateRequired == other.TemplateRequired ||
                    this.TemplateRequired != null &&
                    this.TemplateRequired.Equals(other.TemplateRequired)
                ) && 
                (
                    this.Underline == other.Underline ||
                    this.Underline != null &&
                    this.Underline.Equals(other.Underline)
                ) && 
                (
                    this.Width == other.Width ||
                    this.Width != null &&
                    this.Width.Equals(other.Width)
                ) && 
                (
                    this.XPosition == other.XPosition ||
                    this.XPosition != null &&
                    this.XPosition.Equals(other.XPosition)
                ) && 
                (
                    this.YPosition == other.YPosition ||
                    this.YPosition != null &&
                    this.YPosition.Equals(other.YPosition)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AnchorCaseSensitive != null)
                    hash = hash * 59 + this.AnchorCaseSensitive.GetHashCode();
                if (this.AnchorHorizontalAlignment != null)
                    hash = hash * 59 + this.AnchorHorizontalAlignment.GetHashCode();
                if (this.AnchorIgnoreIfNotPresent != null)
                    hash = hash * 59 + this.AnchorIgnoreIfNotPresent.GetHashCode();
                if (this.AnchorMatchWholeWord != null)
                    hash = hash * 59 + this.AnchorMatchWholeWord.GetHashCode();
                if (this.AnchorString != null)
                    hash = hash * 59 + this.AnchorString.GetHashCode();
                if (this.AnchorUnits != null)
                    hash = hash * 59 + this.AnchorUnits.GetHashCode();
                if (this.AnchorXOffset != null)
                    hash = hash * 59 + this.AnchorXOffset.GetHashCode();
                if (this.AnchorYOffset != null)
                    hash = hash * 59 + this.AnchorYOffset.GetHashCode();
                if (this.Bold != null)
                    hash = hash * 59 + this.Bold.GetHashCode();
                if (this.ButtonText != null)
                    hash = hash * 59 + this.ButtonText.GetHashCode();
                if (this.ConditionalParentLabel != null)
                    hash = hash * 59 + this.ConditionalParentLabel.GetHashCode();
                if (this.ConditionalParentValue != null)
                    hash = hash * 59 + this.ConditionalParentValue.GetHashCode();
                if (this.CustomTabId != null)
                    hash = hash * 59 + this.CustomTabId.GetHashCode();
                if (this.DocumentId != null)
                    hash = hash * 59 + this.DocumentId.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Font != null)
                    hash = hash * 59 + this.Font.GetHashCode();
                if (this.FontColor != null)
                    hash = hash * 59 + this.FontColor.GetHashCode();
                if (this.FontSize != null)
                    hash = hash * 59 + this.FontSize.GetHashCode();
                if (this.Height != null)
                    hash = hash * 59 + this.Height.GetHashCode();
                if (this.Italic != null)
                    hash = hash * 59 + this.Italic.GetHashCode();
                if (this.MergeField != null)
                    hash = hash * 59 + this.MergeField.GetHashCode();
                if (this.PageNumber != null)
                    hash = hash * 59 + this.PageNumber.GetHashCode();
                if (this.RecipientId != null)
                    hash = hash * 59 + this.RecipientId.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.TabId != null)
                    hash = hash * 59 + this.TabId.GetHashCode();
                if (this.TabLabel != null)
                    hash = hash * 59 + this.TabLabel.GetHashCode();
                if (this.TabOrder != null)
                    hash = hash * 59 + this.TabOrder.GetHashCode();
                if (this.TemplateLocked != null)
                    hash = hash * 59 + this.TemplateLocked.GetHashCode();
                if (this.TemplateRequired != null)
                    hash = hash * 59 + this.TemplateRequired.GetHashCode();
                if (this.Underline != null)
                    hash = hash * 59 + this.Underline.GetHashCode();
                if (this.Width != null)
                    hash = hash * 59 + this.Width.GetHashCode();
                if (this.XPosition != null)
                    hash = hash * 59 + this.XPosition.GetHashCode();
                if (this.YPosition != null)
                    hash = hash * 59 + this.YPosition.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
