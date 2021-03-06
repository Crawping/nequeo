//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class MediaFormatVideo : MediaFormat {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MediaFormatVideo(global::System.IntPtr cPtr, bool cMemoryOwn) : base(pjsua2PINVOKE.MediaFormatVideo_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MediaFormatVideo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MediaFormatVideo() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_MediaFormatVideo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public uint width {
    set {
      pjsua2PINVOKE.MediaFormatVideo_width_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaFormatVideo_width_get(swigCPtr);
      return ret;
    } 
  }

  public uint height {
    set {
      pjsua2PINVOKE.MediaFormatVideo_height_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaFormatVideo_height_get(swigCPtr);
      return ret;
    } 
  }

  public int fpsNum {
    set {
      pjsua2PINVOKE.MediaFormatVideo_fpsNum_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.MediaFormatVideo_fpsNum_get(swigCPtr);
      return ret;
    } 
  }

  public int fpsDenum {
    set {
      pjsua2PINVOKE.MediaFormatVideo_fpsDenum_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.MediaFormatVideo_fpsDenum_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_pj_uint32_t avgBps {
    set {
      pjsua2PINVOKE.MediaFormatVideo_avgBps_set(swigCPtr, SWIGTYPE_p_pj_uint32_t.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pj_uint32_t ret = new SWIGTYPE_p_pj_uint32_t(pjsua2PINVOKE.MediaFormatVideo_avgBps_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_pj_uint32_t maxBps {
    set {
      pjsua2PINVOKE.MediaFormatVideo_maxBps_set(swigCPtr, SWIGTYPE_p_pj_uint32_t.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pj_uint32_t ret = new SWIGTYPE_p_pj_uint32_t(pjsua2PINVOKE.MediaFormatVideo_maxBps_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void fromPj(SWIGTYPE_p_pjmedia_format format) {
    pjsua2PINVOKE.MediaFormatVideo_fromPj(swigCPtr, SWIGTYPE_p_pjmedia_format.getCPtr(format));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_pjmedia_format toPj() {
    SWIGTYPE_p_pjmedia_format ret = new SWIGTYPE_p_pjmedia_format(pjsua2PINVOKE.MediaFormatVideo_toPj(swigCPtr), true);
    return ret;
  }

  public MediaFormatVideo() : this(pjsua2PINVOKE.new_MediaFormatVideo(), true) {
  }

}
