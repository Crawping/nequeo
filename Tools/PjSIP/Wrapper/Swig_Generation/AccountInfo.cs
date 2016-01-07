//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class AccountInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal AccountInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AccountInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AccountInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_AccountInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_pjsua_acc_id id {
    set {
      pjsua2PINVOKE.AccountInfo_id_set(swigCPtr, SWIGTYPE_p_pjsua_acc_id.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pjsua_acc_id ret = new SWIGTYPE_p_pjsua_acc_id(pjsua2PINVOKE.AccountInfo_id_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool isDefault {
    set {
      pjsua2PINVOKE.AccountInfo_isDefault_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.AccountInfo_isDefault_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_string uri {
    set {
      pjsua2PINVOKE.AccountInfo_uri_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.AccountInfo_uri_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool regIsConfigured {
    set {
      pjsua2PINVOKE.AccountInfo_regIsConfigured_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.AccountInfo_regIsConfigured_get(swigCPtr);
      return ret;
    } 
  }

  public bool regIsActive {
    set {
      pjsua2PINVOKE.AccountInfo_regIsActive_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.AccountInfo_regIsActive_get(swigCPtr);
      return ret;
    } 
  }

  public int regExpiresSec {
    set {
      pjsua2PINVOKE.AccountInfo_regExpiresSec_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.AccountInfo_regExpiresSec_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_pjsip_status_code regStatus {
    set {
      pjsua2PINVOKE.AccountInfo_regStatus_set(swigCPtr, SWIGTYPE_p_pjsip_status_code.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pjsip_status_code ret = new SWIGTYPE_p_pjsip_status_code(pjsua2PINVOKE.AccountInfo_regStatus_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_string regStatusText {
    set {
      pjsua2PINVOKE.AccountInfo_regStatusText_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.AccountInfo_regStatusText_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_pj_status_t regLastErr {
    set {
      pjsua2PINVOKE.AccountInfo_regLastErr_set(swigCPtr, SWIGTYPE_p_pj_status_t.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pj_status_t ret = new SWIGTYPE_p_pj_status_t(pjsua2PINVOKE.AccountInfo_regLastErr_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool onlineStatus {
    set {
      pjsua2PINVOKE.AccountInfo_onlineStatus_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.AccountInfo_onlineStatus_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_string onlineStatusText {
    set {
      pjsua2PINVOKE.AccountInfo_onlineStatusText_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.AccountInfo_onlineStatusText_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void fromPj(SWIGTYPE_p_pjsua_acc_info pai) {
    pjsua2PINVOKE.AccountInfo_fromPj(swigCPtr, SWIGTYPE_p_pjsua_acc_info.getCPtr(pai));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public AccountInfo() : this(pjsua2PINVOKE.new_AccountInfo(), true) {
  }

}
