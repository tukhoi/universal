using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Davang.Enterprise;
using System.Reflection;
using Davang.Enterprise.Portable;

namespace NewsExplorer.Models.Portable
{
    public class Page : Entity
    {
        public string about { get; set; }
        public string bio { get; set; }
        public string birthday { get; set; }
        public string contact_address { get; set; }
        public CoverPhoto cover { get; set; }
        public string current_location { get; set; }
        public string description { get; set; }
        public IList<string> emails { get; set; }
        public UInt32 fan_count { get; set; }
        public string general_info { get; set; }
        public string hometown { get; set; }
        public DateTime last_used_time { get; set; }
        public string link { get; set; }
        public Location location { get; set; }
        public string name { get; set; }
        public string name_with_location_descriptor { get; set; }
        public UInt32 new_like_count { get; set; }
        public string personal_info { get; set; }
        public string phone { get; set; }
        public UInt32 talking_about_count { get; set; }
        public string username { get; set; }
        public string website { get; set; }

        public static readonly Type TYPE_OF_PAGE = typeof(Page);
        public static readonly IList<string> REMOTE_FIELDS = TYPE_OF_PAGE.GetRuntimeProperties()
                .Select(pi => pi.Name)
                .ToList();

        //public MappedProperty<string> About = new MappedProperty<string>("about");
        //public MappedProperty<string> Bio = new MappedProperty<string>("bio");
        //public MappedProperty<string> Birthday = new MappedProperty<string>("birthday");
        //public MappedProperty<string> Address = new MappedProperty<string>("contact_address");
        //public MappedProperty<string> CoverPhoto = new MappedProperty<string>("cover");
        //public MappedProperty<string> CurrentLocation = new MappedProperty<string>("current_location");
        //public MappedProperty<string> Description = new MappedProperty<string>("description");
        //public MappedProperty<IList<string>> Emails = new MappedProperty<IList<string>>("emails");
        //public MappedProperty<UInt32> FanCount = new MappedProperty<uint>("fan_count");
        //public MappedProperty<string> GeneralInfo = new MappedProperty<string>("general_info");
        //public MappedProperty<string> HomeTown = new MappedProperty<string>("hometown");
        //public MappedProperty<DateTime> LastUsedTime = new MappedProperty<DateTime>("last_used_time");
        //public MappedProperty<string> Link = new MappedProperty<string>("link");
        //public MappedProperty<Location> Location = new MappedProperty<Location>("location");
        //public MappedProperty<string> Name = new MappedProperty<string>("name");
        //public MappedProperty<string> NameWithLocationDescriptor = new MappedProperty<string>("name_with_location_descriptor");
        //public MappedProperty<UInt32> NewLikeCount = new MappedProperty<UInt32>("new_like_count");
        //public MappedProperty<string> PersonalInfo = new MappedProperty<string>("personal_info");
        //public MappedProperty<string> Phone = new MappedProperty<string>("phone");
        //public MappedProperty<UInt32> TalkingAboutCount = new MappedProperty<UInt32>("talking_about_count");
        //public MappedProperty<string> Username = new MappedProperty<string>("username");
        //public MappedProperty<string> Website = new MappedProperty<string>("website");

        //public static readonly Type TYPE_OF_PAGE = typeof(Page);
        //public static readonly Type TYPE_OF_MAPPEDPROPERTY = typeof(MappedProperty<>);
        //public static readonly string REMOTE_FIELDS;

        //static Page()
        //{
        //    var page = new Page();

        //    REMOTE_FIELDS =  string.Join(",", TYPE_OF_PAGE.GetRuntimeFields()
        //        .Where(rf => !rf.IsStatic && rf.FieldType.Name.Equals(TYPE_OF_MAPPEDPROPERTY.Name))
        //        .Select(rf => {
        //            var fieldInstance = rf.GetValue(page) as IMappedProperty;
        //            if (fieldInstance != null)
        //                return fieldInstance.RemoteName;
        //            return null;
        //        })
        //        .Where(remoteName => !string.IsNullOrEmpty(remoteName))
        //        .ToArray());
        //}
        }
}
