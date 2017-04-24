// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Company.json"
// Version: 1004
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
#pragma warning disable 0108
#pragma warning disable 1591

namespace StarcounterApplication2 {
using __Company1__ = global::StarcounterApplication2.Company.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __CoSaveTrig__ = global::StarcounterApplication2.Company.Input.SaveTrigger;
using __CoLastName__ = global::StarcounterApplication2.Company.Input.LastName;
using __CoFirstNam__ = global::StarcounterApplication2.Company.Input.FirstName;
using __CoHtml__ = global::StarcounterApplication2.Company.Input.Html;
using __Company2__ = global::StarcounterApplication2.Company.Input;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __CoSchema__ = global::StarcounterApplication2.Company.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Company__ = global::StarcounterApplication2.Company;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class Company_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class Company : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema__ DefaultTemplate = new __CoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Company() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Company(__CoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CoSchema__ Template { get { return (__CoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Company__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "StarcounterApplication2/CompanyJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__Company__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Company__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                FirstName = Add<__TString__>("FirstName");
                FirstName.DefaultValue = "";
                FirstName.SetCustomAccessors((_p_) => { return ((__Company__)_p_).__bf__FirstName__; }, (_p_, _v_) => { ((__Company__)_p_).__bf__FirstName__ = (System.String)_v_; }, false);
                LastName = Add<__TString__>("LastName");
                LastName.DefaultValue = "";
                LastName.SetCustomAccessors((_p_) => { return ((__Company__)_p_).__bf__LastName__; }, (_p_, _v_) => { ((__Company__)_p_).__bf__LastName__ = (System.String)_v_; }, false);
                SaveTrigger = Add<__TLong__>("SaveTrigger");
                SaveTrigger.DefaultValue = 0L;
                SaveTrigger.SetCustomAccessors((_p_) => { return ((__Company__)_p_).__bf__SaveTrigger__; }, (_p_, _v_) => { ((__Company__)_p_).__bf__SaveTrigger__ = (System.Int64)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Company__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ FirstName;
            public __TString__ LastName;
            public __TLong__ SaveTrigger;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "Company.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "Company.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FirstName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FirstName {
    #line 3 "Company.json"
        get {
        #line hidden
            return Template.FirstName.Getter(this); }
        #line 3 "Company.json"
        set {
        #line hidden
            Template.FirstName.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__LastName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String LastName {
    #line 4 "Company.json"
        get {
        #line hidden
            return Template.LastName.Getter(this); }
        #line 4 "Company.json"
        set {
        #line hidden
            Template.LastName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveTrigger {
    #line 5 "Company.json"
        get {
        #line hidden
            return Template.SaveTrigger.Getter(this); }
        #line 5 "Company.json"
        set {
        #line hidden
            Template.SaveTrigger.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Company__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FirstName : Input<__Company__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class LastName : Input<__Company__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveTrigger : Input<__Company__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
