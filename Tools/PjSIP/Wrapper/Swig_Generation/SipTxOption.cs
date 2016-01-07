//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class SipTxOption : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SipTxOption(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SipTxOption obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SipTxOption() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_SipTxOption(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_string targetUri {
    set {
      pjsua2PINVOKE.SipTxOption_targetUri_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.SipTxOption_targetUri_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__vectorT_pj__SipHeader_t headers {
    set {
      pjsua2PINVOKE.SipTxOption_headers_set(swigCPtr, SWIGTYPE_p_std__vectorT_pj__SipHeader_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SipTxOption_headers_get(swigCPtr);
      SWIGTYPE_p_std__vectorT_pj__SipHeader_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_pj__SipHeader_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_string contentType {
    set {
      pjsua2PINVOKE.SipTxOption_contentType_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.SipTxOption_contentType_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_string msgBody {
    set {
      pjsua2PINVOKE.SipTxOption_msgBody_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.SipTxOption_msgBody_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SipMediaType multipartContentType {
    set {
      pjsua2PINVOKE.SipTxOption_multipartContentType_set(swigCPtr, SipMediaType.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SipTxOption_multipartContentType_get(swigCPtr);
      SipMediaType ret = (cPtr == global::System.IntPtr.Zero) ? null : new SipMediaType(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_std__vectorT_pj__SipMultipartPart_t multipartParts {
    set {
      pjsua2PINVOKE.SipTxOption_multipartParts_set(swigCPtr, SWIGTYPE_p_std__vectorT_pj__SipMultipartPart_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.SipTxOption_multipartParts_get(swigCPtr);
      SWIGTYPE_p_std__vectorT_pj__SipMultipartPart_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__vectorT_pj__SipMultipartPart_t(cPtr, false);
      return ret;
    } 
  }

  public bool isEmpty() {
    bool ret = pjsua2PINVOKE.SipTxOption_isEmpty(swigCPtr);
    return ret;
  }

  public void fromPj(SWIGTYPE_p_pjsua_msg_data prm) {
    pjsua2PINVOKE.SipTxOption_fromPj(swigCPtr, SWIGTYPE_p_pjsua_msg_data.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void toPj(SWIGTYPE_p_pjsua_msg_data msg_data) {
    pjsua2PINVOKE.SipTxOption_toPj(swigCPtr, SWIGTYPE_p_pjsua_msg_data.getCPtr(msg_data));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public SipTxOption() : this(pjsua2PINVOKE.new_SipTxOption(), true) {
  }

}
