﻿using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace XAFDemo.Module.BusinessObjects
{
    [DefaultClassOptions]

    public class Company : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Company(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        private string _Name;
        [RuleRequiredField]
        [RuleUniqueValue]
        public string Name
        {
            get { return _Name; }
            set { SetPropertyValue<string>(nameof(Name), ref _Name, value); }

        }

        private string _Website;
        public string Website
        {
            get { return _Website; }
            set { SetPropertyValue<string>(nameof(Website), ref _Website, value); }

        }
        private string _PhoneNumber;
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { SetPropertyValue<string>(nameof(PhoneNumber), ref _PhoneNumber, value); }

        }
        private string _BillingAddress;
        public string BillingAddress
        {
            get { return _BillingAddress; }
            set { SetPropertyValue<string>(nameof(BillingAddress), ref _BillingAddress, value); }

        }

        private string _ShippingAddress;
        public string ShippingAddress
        {
            get { return _ShippingAddress; }
            set { SetPropertyValue<string>(nameof(ShippingAddress), ref _ShippingAddress, value); }

        }

        private bool _ShippingToBilling;
        [ImmediatePostData]
        public bool ShippingToBilling
        {
            get { return _ShippingToBilling; }
            set { SetPropertyValue<bool>(nameof(ShippingToBilling), ref _ShippingToBilling, value); }

        }

        private bool _IsActive;
        public bool IsActive
        {
            get { return _IsActive; }
            set { SetPropertyValue<bool>(nameof(IsActive), ref _IsActive, value); }

        }

        [DevExpress.Xpo.Aggregated, Association]
        public XPCollection<CompanyContact> Contacts
        {
            get { return GetCollection<CompanyContact>(nameof(Contacts)); }
        }

       
    }
}