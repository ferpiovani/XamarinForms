using System;
using System.Collections.Generic;
using System.Text;

namespace CCAgenda.DL
{
    public class Social
    {
        private Int32 socialID;
        private String socialTel1;
        private String socialTel2;
        private String socialEmail;
        private String socialFacebook;
        private String socialInstagram;
        private String socialTwitter;

        public Social()
        {
            this.socialTel1 = String.Empty;
            this.socialTel2 = String.Empty;
            this.socialEmail = String.Empty;
            this.socialFacebook = String.Empty;
            this.socialInstagram = String.Empty;
            this.socialTwitter = String.Empty;
        }

        public int SocialID { get => socialID; set => socialID = value; }
        public string SocialTel1 { get => socialTel1; set => socialTel1 = value; }
        public string SocialTel2 { get => socialTel2; set => socialTel2 = value; }
        public string SocialEmail { get => socialEmail; set => socialEmail = value; }
        public string SocialFacebook { get => socialFacebook; set => socialFacebook = value; }
        public string SocialInstagram { get => socialInstagram; set => socialInstagram = value; }
        public string SocialTwitter { get => socialTwitter; set => socialTwitter = value; }
    }
}
