//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class SipMediaType : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SipMediaType(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SipMediaType obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SipMediaType() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_SipMediaType(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_string type {
    set {
      pjsua2PINVOKE.SipMediaType_type_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.SipMediaType_type_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_string subType {
    set {
      pjsua2PINVOKE.SipMediaType_subType_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.SipMediaType_subType_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void fromPj(SWIGTYPE_p_pjsip_media_type prm) {
    pjsua2PINVOKE.SipMediaType_fromPj(swigCPtr, SWIGTYPE_p_pjsip_media_type.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_pjsip_media_type toPj() {
    SWIGTYPE_p_pjsip_media_type ret = new SWIGTYPE_p_pjsip_media_type(pjsua2PINVOKE.SipMediaType_toPj(swigCPtr), true);
    return ret;
  }

  public SipMediaType() : this(pjsua2PINVOKE.new_SipMediaType(), true) {
  }

}
