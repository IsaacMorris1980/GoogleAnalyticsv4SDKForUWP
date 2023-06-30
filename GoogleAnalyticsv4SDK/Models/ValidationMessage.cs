using GoogleAnalyticsv4SDK.Validation;

namespace GoogleAnalyticsv4SDK.Models
{
    public class ValidationMessage
    {
        private string fieldPath = string.Empty;
        private string description = string.Empty;
        private ValidationCode validationCode;
        public ValidationMessage()
        {

        }
        public ValidationMessage(string fieldPath)
        {
            this.fieldPath = fieldPath;
        }
        public ValidationMessage(string fieldpath, string description)
        {
            this.fieldPath = fieldpath;
            this.description = description;
        }
        public ValidationMessage(string fieldPath, string description, ValidationCode validationCode)
        {
            this.fieldPath = fieldPath;
            this.description = description;
            this.validationCode = validationCode;
        }
        public string FieldPath
        {
            get
            {
                return this.fieldPath;
            }
            set
            {
                if (this.fieldPath != value)
                {
                    this.fieldPath = value;
                }
            }
        }
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                if (this.description != value)
                {
                    this.description = value;
                }
            }
        }
        public ValidationCode ValidationCode
        {
            get
            {
                return this.validationCode;
            }
            set
            {
                if (this.validationCode != value)
                {
                    this.validationCode = value;
                }
            }
        }
    }
}
