//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class MediaEventData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MediaEventData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MediaEventData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MediaEventData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_MediaEventData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public MediaFmtChangedEvent fmtChanged {
    set {
      pjsua2PINVOKE.MediaEventData_fmtChanged_set(swigCPtr, MediaFmtChangedEvent.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.MediaEventData_fmtChanged_get(swigCPtr);
      MediaFmtChangedEvent ret = (cPtr == global::System.IntPtr.Zero) ? null : new MediaFmtChangedEvent(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_GenericData ptr {
    set {
      pjsua2PINVOKE.MediaEventData_ptr_set(swigCPtr, SWIGTYPE_p_GenericData.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_GenericData ret = new SWIGTYPE_p_GenericData(pjsua2PINVOKE.MediaEventData_ptr_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public MediaEventData() : this(pjsua2PINVOKE.new_MediaEventData(), true) {
  }

}
