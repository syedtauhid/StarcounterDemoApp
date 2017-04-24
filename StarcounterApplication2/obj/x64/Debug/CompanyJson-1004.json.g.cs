// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "CompanyJson.json"
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
using __CompanyJ2__ = global::StarcounterApplication2.CompanyJson.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __CoFullName__ = global::StarcounterApplication2.CompanyJson.Input.FullName;
using __CoSaveTrig__ = global::StarcounterApplication2.CompanyJson.Input.SaveTrigger;
using __CoLastName__ = global::StarcounterApplication2.CompanyJson.Input.LastName;
using __CoFirstNam__ = global::StarcounterApplication2.CompanyJson.Input.FirstName;
using __CoHtml__ = global::StarcounterApplication2.CompanyJson.Input.Html;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __CoSchema__ = global::StarcounterApplication2.CompanyJson.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __CompanyJ__ = global::StarcounterApplication2.CompanyJson;
using __CompanyJ1__ = global::StarcounterApplication2.CompanyJson.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CompanyJson_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class CompanyJson : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema__ DefaultTemplate = new __CoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CompanyJson() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CompanyJson(__CoSchema__ template) { Template = template; }
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
                InstanceType = typeof(__CompanyJ__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/StarcounterApplication2/CompanyJson.html";
                Html.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                FirstName = Add<__TString__>("FirstName$");
                FirstName.DefaultValue = "";
                FirstName.Editable = true;
                FirstName.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__FirstName__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__FirstName__ = (System.String)_v_; }, false);
                LastName = Add<__TString__>("LastName$");
                LastName.DefaultValue = "";
                LastName.Editable = true;
                LastName.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__LastName__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__LastName__ = (System.String)_v_; }, false);
                SaveTrigger = Add<__TLong__>("SaveTrigger$");
                SaveTrigger.DefaultValue = 0L;
                SaveTrigger.Editable = true;
                SaveTrigger.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__SaveTrigger__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__SaveTrigger__ = (System.Int64)_v_; }, false);
                SaveTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveTrigger() { App = (CompanyJson)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CompanyJson)pup).Handle((Input.SaveTrigger)input); });
                FullName = Add<__TString__>("FullName", bind:"FullName");
                FullName.DefaultValue = "";
                FullName.SetCustomAccessors((_p_) => { return ((__CompanyJ__)_p_).__bf__FullName__; }, (_p_, _v_) => { ((__CompanyJ__)_p_).__bf__FullName__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __CompanyJ__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ FirstName;
            public __TString__ LastName;
            public __TLong__ SaveTrigger;
            public __TString__ FullName;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "CompanyJson.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "CompanyJson.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FirstName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FirstName {
    #line 3 "CompanyJson.json"
        get {
        #line hidden
            return Template.FirstName.Getter(this); }
        #line 3 "CompanyJson.json"
        set {
        #line hidden
            Template.FirstName.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__LastName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String LastName {
    #line 4 "CompanyJson.json"
        get {
        #line hidden
            return Template.LastName.Getter(this); }
        #line 4 "CompanyJson.json"
        set {
        #line hidden
            Template.LastName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveTrigger {
    #line 5 "CompanyJson.json"
        get {
        #line hidden
            return Template.SaveTrigger.Getter(this); }
        #line 5 "CompanyJson.json"
        set {
        #line hidden
            Template.SaveTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__FullName__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__CompanyJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FirstName : Input<__CompanyJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class LastName : Input<__CompanyJ__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveTrigger : Input<__CompanyJ__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class FullName : Input<__CompanyJ__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
