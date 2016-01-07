/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace pjsua2 {

public class Error : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Error(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Error obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Error() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_Error(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public int status {
    set {
      pjsua2PINVOKE.Error_status_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.Error_status_get(swigCPtr);
      return ret;
    } 
  }

  public string title {
    set {
      pjsua2PINVOKE.Error_title_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.Error_title_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string reason {
    set {
      pjsua2PINVOKE.Error_reason_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.Error_reason_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public string srcFile {
    set {
      pjsua2PINVOKE.Error_srcFile_set(swigCPtr, value);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      string ret = pjsua2PINVOKE.Error_srcFile_get(swigCPtr);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public int srcLine {
    set {
      pjsua2PINVOKE.Error_srcLine_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.Error_srcLine_get(swigCPtr);
      return ret;
    } 
  }

  public string info(bool multi_line) {
    string ret = pjsua2PINVOKE.Error_info__SWIG_0(swigCPtr, multi_line);
    return ret;
  }

  public string info() {
    string ret = pjsua2PINVOKE.Error_info__SWIG_1(swigCPtr);
    return ret;
  }

  public Error() : this(pjsua2PINVOKE.new_Error__SWIG_0(), true) {
  }

  public Error(int prm_status, string prm_title, string prm_reason, string prm_src_file, int prm_src_line) : this(pjsua2PINVOKE.new_Error__SWIG_1(prm_status, prm_title, prm_reason, prm_src_file, prm_src_line), true) {
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

}

}
