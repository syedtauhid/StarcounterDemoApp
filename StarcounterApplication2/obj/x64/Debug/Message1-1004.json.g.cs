// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Message1.json"
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
using __Message1__ = global::StarcounterApplication2.Message1;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __MeSchema__ = global::StarcounterApplication2.Message1.JsonByExample.Schema;
using __Message11__ = global::StarcounterApplication2.Message1.JsonByExample;
using __Message12__ = global::StarcounterApplication2.Message1.Input;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;

#line hidden
public partial class Message1 : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __MeSchema__ DefaultTemplate = new __MeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Message1() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public Message1(__MeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __MeSchema__ Template { get { return (__MeSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Message1__);
                Properties.ClearExposed();
            }
            public override object CreateInstance(s.Json parent) { return new __Message1__(this) { Parent = parent }; }
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
    }
    #line default
}
#line default

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class Message1_json : s::TemplateAttribute {
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
