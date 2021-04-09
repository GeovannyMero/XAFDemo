using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XAFDemo.Module.BusinessObjects
{
    [DefaultClassOptions]
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class Meeting : Event
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Meeting(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        private Company _Company;
        [ImmediatePostData]
        public Company Company
        {
            get { return _Company; }
            set { SetPropertyValue<Company>(nameof(Company), ref _Company, value); }
        }

        private CompanyContact _PrimaryContact;
        [DataSourceProperty("Company.Contacts")]
        public CompanyContact PrimaryContact { 
            get { return _PrimaryContact; }
            set { SetPropertyValue<CompanyContact>(nameof(PrimaryContact), ref _PrimaryContact, value); }
            
        }
    }
}