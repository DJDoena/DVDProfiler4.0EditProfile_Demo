using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

// 
// xsd.exe /c /l:cs /n:DoenaSoft.DVDProfiler.DVDProfilerXML.Version381 DVDProfiler381.xsd
//

namespace DoenaSoft.DVDProfiler.DVDProfilerXML.Version381
{
    public static class Countries
    {
        public static readonly Dictionary<Int32, String> Dictionary;

        static Countries()
        {
            Dictionary = new Dictionary<Int32, String>(52);
            Dictionary.Add(0, "United States");
            Dictionary.Add(1, "New Zealand");
            Dictionary.Add(2, "Australia");
            Dictionary.Add(3, "Canada");
            Dictionary.Add(4, "United Kingdom");
            Dictionary.Add(5, "Germany");
            Dictionary.Add(6, "China");
            Dictionary.Add(7, "Former Soviet Union");
            Dictionary.Add(8, "France");
            Dictionary.Add(9, "Netherlands");
            Dictionary.Add(10, "Spain");
            Dictionary.Add(11, "Sweden");
            Dictionary.Add(12, "Norway");
            Dictionary.Add(13, "Italy");
            Dictionary.Add(14, "Denmark");
            Dictionary.Add(15, "Portugal");
            Dictionary.Add(16, "Finland");
            Dictionary.Add(17, "Japan");
            Dictionary.Add(18, "South Korea");
            Dictionary.Add(19, "Canada (Quebec)");
            Dictionary.Add(20, "South Africa");
            Dictionary.Add(21, "Hong Kong");
            Dictionary.Add(22, "Switzerland");
            Dictionary.Add(23, "Brazil");
            Dictionary.Add(24, "Israel");
            Dictionary.Add(25, "Mexico");
            Dictionary.Add(26, "Iceland");
            Dictionary.Add(27, "Indonesia");
            Dictionary.Add(28, "Taiwan");
            Dictionary.Add(29, "Poland");
            Dictionary.Add(30, "Belgium");
            Dictionary.Add(31, "Turkey");
            Dictionary.Add(32, "Argentina");
            Dictionary.Add(33, "Slovakia");
            Dictionary.Add(34, "Hungary");
            Dictionary.Add(35, "Singapore");
            Dictionary.Add(36, "Czech Republic");
            Dictionary.Add(37, "Malaysia");
            Dictionary.Add(38, "Thailand");
            Dictionary.Add(39, "India");
            Dictionary.Add(40, "Austria");
            Dictionary.Add(41, "Greece");
            Dictionary.Add(42, "Vietnam");
            Dictionary.Add(43, "Philippines");
            Dictionary.Add(44, "Ireland");
            Dictionary.Add(45, "Estonia");
            Dictionary.Add(46, "Romania");
            Dictionary.Add(47, "Iran");
            Dictionary.Add(48, "Russia");
            Dictionary.Add(49, "Chile");
            Dictionary.Add(50, "Colombia");
            Dictionary.Add(51, "Peru");

        }
    }

    public partial class Collection
    {
        private static XmlSerializer s_XmlSerializer;

        [XmlIgnore()]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if(s_XmlSerializer == null)
                {
                    s_XmlSerializer = new XmlSerializer(typeof(Collection));
                }
                return (s_XmlSerializer);
            }
        }

        public static void Serialize(String fileName, Collection instance)
        {
            using(FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using(XmlTextWriter xtw = new XmlTextWriter(fs, Encoding.GetEncoding("windows-1252")))
                {
                    xtw.Formatting = Formatting.Indented;
                    XmlSerializer.Serialize(xtw, instance);
                }
            }
        }

        public void Serialize(String fileName)
        {
            Serialize(fileName, this);
        }

        public static Collection Deserialize(String fileName)
        {
            using(FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using(XmlTextReader xtr = new XmlTextReader(fs))
                {
                    Collection instance;

                    instance = (Collection)(XmlSerializer.Deserialize(xtr));
                    return (instance);
                }
            }
        }

        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            sb.Append("Count: ");
            if(this.DVDList != null)
            {
                sb.Append(this.DVDList.Length);
            }
            else
            {
                sb.Append("none");
            }
            return (sb.ToString());
        }

        [XmlAnyElement()]
        public XmlNode[] OpenElements;
    }

    public partial class DVD : IComparable<DVD>
    {
        private static XmlSerializer s_XmlSerializer;

        public DVD()
        {
            this.ProfileTimestamp = DateTime.UtcNow;
            this.ID = String.Empty;
            this.MediaTypes = new MediaTypes();
            this.UPC = String.Empty;
            this.CollectionNumber = String.Empty;
            this.CollectionType = new CollectionType();
            this.Title = String.Empty;
            this.Edition = String.Empty;
            this.OriginalTitle = String.Empty;
            this.CountryOfOrigin = String.Empty;
            this.RatingSystem = String.Empty;
            this.Rating = String.Empty;
            this.CaseType = String.Empty;
            this.GenreList = new String[0];
            this.RegionList = new String[0];
            this.Format = new Format();
            this.Features = new Features();
            this.StudioList = new String[0];
            this.MediaCompanyList = new String[0];
            this.AudioList = new AudioTrack[0];
            this.SubtitleList = new String[0];
            this.SRP = new Price();
            this.DiscList = new Disc[0];
            this.SortTitle = String.Empty;
            this.PurchaseInfo = new PurchaseInfo();
            this.Review = new Review();
            this.MediaBanners = new MediaBanners();
            this.EventList = new Event[0];
            this.BoxSet = new BoxSet();
            this.LoanInfo = new LoanInfo();
        }

        [XmlIgnore()]
        public Int32 LocalityAsID
        {
            [DebuggerStepThrough()]
            get
            {
                String[] split;

                split = this.ID.Split('.');
                if(split.Length == 1)
                {
                    return (0);
                }
                else
                {
                    if(split[1] == String.Empty)
                    {
                        return (0);
                    }
                    else
                    {
                        return (Int32.Parse(split[1]));
                    }
                }
            }
        }

        [XmlIgnore()]
        public String LocalityAsText
        {
            get
            {
                String locality;

                if(Countries.Dictionary.TryGetValue(this.LocalityAsID, out locality) == false)
                {
                    locality = "<unknown>";
                }
                return (locality);
            }
        }

        [XmlIgnore()]
        public static XmlSerializer XmlSerializer
        {
            get
            {
                if(s_XmlSerializer == null)
                {
                    s_XmlSerializer = new XmlSerializer(typeof(DVD));
                }
                return (s_XmlSerializer);
            }
        }

        public static void Serialize(String fileName, DVD instance)
        {
            using(FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using(XmlTextWriter xtw = new XmlTextWriter(fs, Encoding.GetEncoding("windows-1252")))
                {
                    xtw.Formatting = Formatting.Indented;
                    XmlSerializer.Serialize(xtw, instance);
                }
            }
        }

        public void Serialize(String fileName)
        {
            Serialize(fileName, this);
        }

        public static DVD Deserialize(String fileName)
        {
            using(FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using(XmlTextReader xtr = new XmlTextReader(fs))
                {
                    DVD instance;

                    instance = (DVD)(XmlSerializer.Deserialize(xtr));
                    return (instance);
                }
            }
        }

        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            sb.Append(this.Title);
            if(String.IsNullOrEmpty(this.Edition) == false)
            {
                sb.Append(": ");
                sb.Append(this.Edition);
            }
            sb.Append(" (");
            sb.Append(this.UPC);
            sb.Append(")");
            return (sb.ToString());
        }

        public override Boolean Equals(Object obj)
        {
            DVD other;

            other = obj as DVD;
            if(other == null)
            {
                return (false);
            }
            return (this.ID == other.ID);
        }

        public override Int32 GetHashCode()
        {
            return (this.idField.GetHashCode());
        }

        [XmlAnyElement()]
        public XmlNode[] OpenElements;

        #region IComparable<DVD> Members
        public Int32 CompareTo(DVD other)
        {
            if (other == null)
            {
                return (1);
            }
            return (CompareSortTitle(this, other));
        }
        #endregion

        private static Int32 CompareSortTitle(DVD left, DVD right)
        {
            if (left.SortTitle == null)
            {
                if (right.SortTitle == null)
                {
                    return (0);
                }
                else
                {
                    return (-1);
                }
            }
            else if (right.SortTitle == null)
            {
                return (1);
            }
            else
            {
                Int32 compare;

                compare = left.SortTitle.CompareTo(right.SortTitle);
                if (compare == 0)
                {
                    compare = CompareId(left, right);
                }
                return (compare);
            }
        }

        private static Int32 CompareId(DVD left, DVD right)
        {
            if (left.ID == null)
            {
                if (right.ID == null)
                {
                    return (0);
                }
                else
                {
                    return (-1);
                }
            }
            else if (right.ID == null)
            {
                return (1);
            }
            else
            {
                return (left.ID.CompareTo(right.ID));
            }
        }
    }

    public partial class MediaTypes
    {
        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            if(this.DVD)
            {
                sb.Append("DVD");
            }
            if(this.BluRay)
            {
                if(sb.Length > 0)
                {
                    sb.Append(" / ");
                }
                sb.Append("Blu-ray");
            }
            if(this.HDDVD)
            {
                if(sb.Length > 0)
                {
                    sb.Append(" / ");
                }
                sb.Append("HD-DVD");
            }
            if(String.IsNullOrEmpty(this.CustomMediaType) == false)
            {
                if(sb.Length > 0)
                {
                    sb.Append(" / ");
                }
                sb.Append(this.CustomMediaType);
            }
            return (sb.ToString());
        }

        [XmlAnyElement()]
        public XmlNode[] OpenElements;
    }

    public partial class BasicDVD
    {
        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            sb.Append(this.Title);
            if(String.IsNullOrEmpty(this.Edition) == false)
            {
                sb.Append(": ");
                sb.Append(this.Edition);
            }
            sb.Append(" (");
            sb.Append(this.UPC);
            sb.Append(")");
            return (sb.ToString());
        }

        [XmlIgnore()]
        public Int32 LocalityAsID
        {
            [DebuggerStepThrough()]
            get
            {
                String[] split;

                split = this.ID.Split('.');
                if(split.Length == 1)
                {
                    return (0);
                }
                else
                {
                    if(split[1] == String.Empty)
                    {
                        return (0);
                    }
                    else
                    {
                        return (Int32.Parse(split[1]));
                    }
                }
            }
        }

        [XmlIgnore()]
        public String LocalityAsText
        {
            get
            {
                String locality;

                if(Countries.Dictionary.TryGetValue(this.LocalityAsID, out locality) == false)
                {
                    locality = "<unknown>";
                }
                return (locality);
            }
        }
    }

    public partial class CollectionType
    {
        public CollectionType()
        {
            this.Value = String.Empty;
        }

        public override String ToString()
        {
            return (this.Value + "(Owned: " + this.IsPartOfOwnedCollection.ToString() + ")");
        }

        public override Int32 GetHashCode()
        {
            return (this.Value.GetHashCode());
        }

        public override Boolean Equals(Object obj)
        {
            CollectionType other;

            other = obj as CollectionType;
            if(other == null)
            {
                return (false);
            }
            return ((this.Value == other.Value) && (this.IsPartOfOwnedCollection == other.IsPartOfOwnedCollection));
        }

        [XmlAnyAttribute()]
        public XmlNode[] OpenAttributes;
    }

    public partial class Locks
    {
        [XmlAnyElement()]
        public XmlNode[] OpenElements;
    }

    public partial class Tag
    {
        public Tag()
        {
            this.Name = String.Empty;
            this.FullName = String.Empty;
        }

        public override String ToString()
        {
            return (this.FullName);
        }

        [XmlAnyAttribute()]
        public XmlNode[] OpenAttributes;
    }

    public partial class LoanInfo
    {
        public override String ToString()
        {
            if(this.Loaned)
            {
                StringBuilder sb;

                sb = new StringBuilder();
                if(this.DueSpecified)
                {
                    sb.Append("until");
                    sb.Append(this.Due.ToShortDateString());
                }
                if(this.User != null)
                {
                    if(this.DueSpecified)
                    {
                        sb.Append(" ");
                    }
                    sb.Append("by ");
                    sb.Append(this.User.ToString());
                }
                return (sb.ToString());
            }
            else
            {
                return ("not loaned");
            }
        }

        [XmlAnyElement()]
        public XmlNode[] OpenElements;
    }

    public partial class BasicUser
    {
        public BasicUser()
        {
            this.FirstName = String.Empty;
            this.LastName = String.Empty;
        }

        public override String ToString()
        {
            StringBuilder name;

            name = new StringBuilder();
            if(String.IsNullOrEmpty(this.FirstName) == false)
            {
                name.Append(this.FirstName);
            }
            if(String.IsNullOrEmpty(this.LastName) == false)
            {
                if(name.Length != 0)
                {
                    name.Append(" ");
                }
                name.Append(this.LastName);
            }
            return (name.ToString());
        }

        [XmlAnyAttribute()]
        public XmlNode[] OpenAttributes;
    }

    public partial class User : BasicUser
    {
        public User()
        {
            this.EmailAddress = String.Empty;
            this.PhoneNumber = String.Empty;
        }

        public User(BasicUser user)
        {
            this.FirstName = user.FirstName;
            this.LastName = user.LastName;
            this.EmailAddress = String.Empty;
            this.PhoneNumber = String.Empty;
        }
    }

    public partial class BoxSet
    {
        public BoxSet()
        {
            this.Parent = String.Empty;
            this.ContentList = new String[0];
        }

        [XmlAnyElement()]
        public XmlNode[] OpenElements;
    }

    public partial class Event
    {
        public Event()
        {
            this.Type = EventType.Watched;
            this.Timestamp = DateTime.UtcNow;
            this.User = new User();
        }

        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            sb.Append(this.Type);
            sb.Append(" at ");
            sb.Append(this.Timestamp.ToShortDateString());
            if(this.User != null)
            {
                sb.Append(" by ");
                sb.Append(this.User.ToString());
            }
            return (sb.ToString());
        }

        [XmlAnyElement()]
        public XmlNode[] OpenElements;
    }

    public partial class Exclusions
    {
        [XmlAnyElement()]
        public XmlNode[] OpenElements;
    }

    public partial class MediaBanners
    {
        public MediaBanners()
        {
            this.Front = MediaBannersRestriction.Automatic;
            this.Back = MediaBannersRestriction.Automatic;
        }

        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            sb.Append(this.Front);
            sb.Append(" / ");
            sb.Append(this.Back);
            return (sb.ToString());
        }

        [XmlAnyAttribute()]
        public XmlNode[] OpenAttributes;
    }

    public partial class Review
    {
        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            sb.Append("Film: ");
            sb.Append(this.Film);
            sb.Append(" / Video: ");
            sb.Append(this.Video);
            sb.Append(" / Audio: ");
            sb.Append(this.Audio);
            sb.Append(" / Extras: ");
            sb.Append(this.Extras);
            return (sb.ToString());
        }

        [XmlAnyAttribute()]
        public XmlNode[] OpenAttributes;
    }

    public partial class PurchaseInfo
    {
        public PurchaseInfo()
        {
            this.Price = new Price();
            this.Place = String.Empty;
            this.Type = String.Empty;
            this.Website = String.Empty;
        }

        public override String ToString()
        {
            if(this.Price != null)
            {
                StringBuilder sb;

                sb = new StringBuilder();
                sb.Append(this.Price);
                if(this.DateSpecified)
                {
                    sb.Append(" at ");
                    sb.Append(this.Date.ToShortDateString());
                }
                return (sb.ToString());
            }
            return (base.ToString());
        }

        [XmlAnyElement()]
        public XmlNode[] OpenElements;
    }

    public partial class Price
    {
        public Price()
        {
            this.DenominationType = String.Empty;
            this.DenominationDesc = String.Empty;
            this.FormattedValue = String.Empty;
        }

        public override String ToString()
        {
            return (this.FormattedValue);
        }

        [XmlAnyAttribute()]
        public XmlNode[] OpenAttributes;
    }

    public partial class Disc
    {
        public Disc()
        {
            this.DescriptionSideA = String.Empty;
            this.DescriptionSideB = String.Empty;
            this.DiscIDSideA = String.Empty;
            this.DiscIDSideB = String.Empty;
            this.LabelSideA = String.Empty;
            this.LabelSideB = String.Empty;
            this.Location = String.Empty;
            this.Slot = String.Empty;
        }

        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            sb.Append(this.DescriptionSideA);
            if(String.IsNullOrEmpty(this.DescriptionSideB) == false)
            {
                sb.Append(" / ");
                sb.Append(this.DescriptionSideB);
            }
            return (sb.ToString());
        }

        [XmlAnyElement()]
        public XmlNode[] OpenElements;
    }

    public partial class CrewMember 
    {
        public CrewMember()
        {
            this.FirstName = String.Empty;
            this.MiddleName = String.Empty;
            this.LastName = String.Empty;
            this.CreditType = String.Empty;
            this.CreditSubtype = String.Empty;
            this.CustomRole = String.Empty;
            this.CreditedAs = String.Empty;
        }

        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            if(String.IsNullOrEmpty(this.FirstName) == false)
            {
                sb.Append(this.FirstName);
            }
            if(String.IsNullOrEmpty(this.MiddleName) == false)
            {
                if(sb.Length != 0)
                {
                    sb.Append(" ");
                }
                sb.Append(this.MiddleName);
            }
            if(String.IsNullOrEmpty(this.LastName) == false)
            {
                if(sb.Length != 0)
                {
                    sb.Append(" ");
                }
                sb.Append(this.LastName);
            }
            if(this.BirthYear > 0)
            {
                if(sb.Length != 0)
                {
                    sb.Append(" ");
                }
                sb.Append("(" + this.BirthYear + ")");
            }
            sb.Append(": ");
            sb.Append(this.CreditType);
            sb.Append(" / ");
            sb.Append(this.CreditSubtype);
            if(String.IsNullOrEmpty(this.CustomRole) == false)
            {
                sb.Append(" (");
                sb.Append(this.CustomRole);
                sb.Append(")");
            }
            if(String.IsNullOrEmpty(this.CreditedAs) == false)
            {
                sb.Append(" (as ");
                sb.Append(this.CreditedAs);
                sb.Append(")");
            }
            return (sb.ToString());
        }

        [XmlAnyAttribute()]
        public XmlNode[] OpenAttributes;
    }

    public partial class CastMember
    {
        public CastMember()
        {
            this.FirstName = String.Empty;
            this.MiddleName = String.Empty;
            this.LastName = String.Empty;
            this.Role = String.Empty;
            this.CreditedAs = String.Empty;
        }

        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            if(String.IsNullOrEmpty(this.FirstName) == false)
            {
                sb.Append(this.FirstName);
            }
            if(String.IsNullOrEmpty(this.MiddleName) == false)
            {
                if(sb.Length != 0)
                {
                    sb.Append(" ");
                }
                sb.Append(this.MiddleName);
            }
            if(String.IsNullOrEmpty(this.LastName) == false)
            {
                if(sb.Length != 0)
                {
                    sb.Append(" ");
                }
                sb.Append(this.LastName);
            }
            if(this.BirthYear > 0)
            {
                if(sb.Length != 0)
                {
                    sb.Append(" ");
                }
                sb.Append("(" + this.BirthYear + ")");
            }
            sb.Append(": ");
            sb.Append(this.Role);
            if(this.Voice)
            {
                sb.Append(" (voice)");
            }
            if(this.Uncredited)
            {
                sb.Append(" (uncredited)");
            }
            if(String.IsNullOrEmpty(this.CreditedAs) == false)
            {
                sb.Append(" (as ");
                sb.Append(this.CreditedAs);
                sb.Append(")");
            }
            return (sb.ToString());
        }

        [XmlAnyAttribute()]
        public XmlNode[] OpenAttributes;
    }

    public partial class Divider
    {
        public Divider()
        {
            this.Caption = String.Empty;
            this.Type = DividerType.Episode;
        }

        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            sb.Append(this.Caption);
            sb.Append(" (");
            sb.Append(this.Type);
            sb.Append(")");
            return (sb.ToString());
        }

        [XmlAnyAttribute()]
        public XmlNode[] OpenAttributes;
    }

    public partial class CrewDivider : Divider
    {
        public CrewDivider()
        {
            this.CreditType = String.Empty;
        }

        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            sb.Append(this.Caption);
            sb.Append(" (");
            sb.Append(this.Type);
            if(this.Type != DividerType.Episode)
            {
                sb.Append(", ");
                sb.Append(this.CreditType);
            }
            sb.Append(")");
            return (sb.ToString());
        }

        public Boolean ShouldSerializeCreditType()
        {
            return (this.Type != DividerType.Episode);
        }
    }

    public partial class AudioTrack
    {
        public AudioTrack()
        {
            this.Content = String.Empty;
            this.Format = String.Empty;
            this.Channels = String.Empty;
        }

        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            sb.Append(this.Content);
            sb.Append(" / ");
            sb.Append(this.Format);
            sb.Append(" / ");
            sb.Append(this.Channels);
            return (sb.ToString());
        }

        [XmlAnyElement()]
        public XmlNode[] OpenElements;
    }

    public partial class Features
    {
        public Features()
        {
            this.OtherFeatures = String.Empty;
        }

        [XmlAnyElement()]
        public XmlNode[] OpenElements;
    }

    public partial class Dimensions
    {
        public override String ToString()
        {
            return ("2D: " + this.Dim2D.ToString() + ", 3D Anaglyph: " + this.Dim3DAnaglyph.ToString() 
                + ", 3D Blu-ray: " + this.Dim3DBluRay.ToString());
        }
        
        [XmlAnyElement()]
        public XmlNode[] OpenElements;
    }

    public partial class Format
    {
        public Format()
        {
            this.AspectRatio = String.Empty;
            this.Color = new FormatColor();
            this.Dimensions = new Dimensions();
        }

        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            sb.Append(this.VideoStandard);
            sb.Append(" ");
            sb.Append(this.AspectRatio);
            return (sb.ToString());
        }

        [XmlAnyElement()]
        public XmlNode[] OpenElements;
    }

    public partial class FormatColor
    {
        public override String ToString()
        {
            return ("Color: " + this.Color.ToString() + ", B/W: " + this.BlackAndWhite.ToString()
                + ", Colorized: " + this.Colorized.ToString() + ", Mixed: " + this.Mixed.ToString());
        }

        [XmlAnyElement()]
        public XmlNode[] OpenElements;
    }

    public partial class BasicCollection
    {
        private static XmlSerializer s_XmlSerializer;

        [XmlIgnore()]
        public static XmlSerializer XmlSerializer
        {
            [DebuggerStepThrough()]
            get
            {
                if(s_XmlSerializer == null)
                {
                    s_XmlSerializer = new XmlSerializer(typeof(BasicCollection));
                }
                return (s_XmlSerializer);
            }
        }

        public static void Serialize(String fileName, BasicCollection instance)
        {
            using(FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using(XmlTextWriter xtw = new XmlTextWriter(fs, Encoding.GetEncoding("windows-1252")))
                {
                    xtw.Formatting = Formatting.Indented;
                    XmlSerializer.Serialize(xtw, instance);
                }
            }
        }

        public void Serialize(String fileName)
        {
            Serialize(fileName, this);
        }

        public static BasicCollection Deserialize(String fileName)
        {
            using(FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using(XmlTextReader xtr = new XmlTextReader(fs))
                {
                    BasicCollection instance;

                    instance = (BasicCollection)(XmlSerializer.Deserialize(xtr));
                    return (instance);
                }
            }
        }

        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            sb.Append("Count: ");
            if(this.DVDList != null)
            {
                sb.Append(this.DVDList.Length);
            }
            else
            {
                sb.Append("none");
            }
            return (sb.ToString());
        }
    }

    public partial class CastInformation
    {
        private static XmlSerializer s_XmlSerializer;

        public CastInformation()
        {
            this.Title = String.Empty;
            this.CastList = new Object[0];
        }

        [XmlIgnore()]
        public static XmlSerializer XmlSerializer
        {
            [DebuggerStepThrough()]
            get
            {
                if(s_XmlSerializer == null)
                {
                    s_XmlSerializer = new XmlSerializer(typeof(CastInformation));
                }
                return (s_XmlSerializer);
            }
        }

        public static void Serialize(String fileName, CastInformation instance)
        {
            using(FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using(XmlTextWriter xtw = new XmlTextWriter(fs, Encoding.GetEncoding("ISO-8859-1")))
                {
                    xtw.Formatting = Formatting.Indented;
                    XmlSerializer.Serialize(xtw, instance);
                }
            }
        }

        public void Serialize(String fileName)
        {
            Serialize(fileName, this);
        }

        public static CastInformation Deserialize(String fileName)
        {
            using(FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using(XmlTextReader xtr = new XmlTextReader(fs))
                {
                    CastInformation instance;

                    instance = (CastInformation)(XmlSerializer.Deserialize(xtr));
                    return (instance);
                }
            }
        }

        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            sb.Append(this.Title);
            sb.Append("(Count: ");
            if(this.CastList != null)
            {
                sb.Append(this.CastList.Length);
            }
            else
            {
                sb.Append("none");
            }
            sb.Append(")");
            return (sb.ToString());
        }

        [XmlAnyElement()]
        public XmlNode[] OpenElements;
    }

    public partial class CrewInformation
    {
        private static XmlSerializer s_XmlSerializer;

        public CrewInformation()
        {
            this.Title = String.Empty;
            this.CrewList = new Object[0];
        }

        [XmlIgnore()]
        public static XmlSerializer XmlSerializer
        {
            [DebuggerStepThrough()]
            get
            {
                if(s_XmlSerializer == null)
                {
                    s_XmlSerializer = new XmlSerializer(typeof(CrewInformation));
                }
                return (s_XmlSerializer);
            }
        }

        public static void Serialize(String fileName, CrewInformation instance)
        {
            using(FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using(XmlTextWriter xtw = new XmlTextWriter(fs, Encoding.GetEncoding("ISO-8859-1")))
                {
                    xtw.Formatting = Formatting.Indented;
                    XmlSerializer.Serialize(xtw, instance);
                }
            }
        }

        public void Serialize(String fileName)
        {
            Serialize(fileName, this);
        }

        public static CrewInformation Deserialize(String fileName)
        {
            using(FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using(XmlTextReader xtr = new XmlTextReader(fs))
                {
                    CrewInformation instance;

                    instance = (CrewInformation)(XmlSerializer.Deserialize(xtr));
                    return (instance);
                }
            }
        }

        public override String ToString()
        {
            StringBuilder sb;

            sb = new StringBuilder();
            sb.Append(this.Title);
            sb.Append("(Count: ");
            if(this.CrewList != null)
            {
                sb.Append(this.CrewList.Length);
            }
            else
            {
                sb.Append("none");
            }
            sb.Append(")");
            return (sb.ToString());
        }

        [XmlAnyElement()]
        public XmlNode[] OpenElements;
    }
}