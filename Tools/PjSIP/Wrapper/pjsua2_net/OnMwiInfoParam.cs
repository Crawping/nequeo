/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace pjsua2 {

public class OnMwiInfoParam : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OnMwiInfoParam(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OnMwiInfoParam obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OnMwiInfoParam() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_OnMwiInfoParam(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public pjsip_evsub_state state {
    set {
      pjsua2PINVOKE.OnMwiInfoParam_state_set(swigCPtr, (int)value);
    } 
    get {
      pjsip_evsub_state ret = (pjsip_evsub_state)pjsua2PINVOKE.OnMwiInfoParam_state_get(swigCPtr);
      return ret;
    } 
  }

  public SipRxData rdata {
    set {
      pjsua2PINVOKE.OnMwiInfoParam_rdata_set(swigCPtr, SipRxData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.OnMwiInfoParam_rdata_get(swigCPtr);
      SipRxData ret = (cPtr == global::System.IntPtr.Zero) ? null : new SipRxData(cPtr, false);
      return ret;
    } 
  }

  public OnMwiInfoParam() : this(pjsua2PINVOKE.new_OnMwiInfoParam(), true) {
  }

}

}
