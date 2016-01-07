//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class StreamInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal StreamInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(StreamInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~StreamInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_StreamInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_p_pjmedia_type type {
    set {
      pjsua2PINVOKE.StreamInfo_type_set(swigCPtr, SWIGTYPE_p_pjmedia_type.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pjmedia_type ret = new SWIGTYPE_p_pjmedia_type(pjsua2PINVOKE.StreamInfo_type_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_pjmedia_tp_proto proto {
    set {
      pjsua2PINVOKE.StreamInfo_proto_set(swigCPtr, SWIGTYPE_p_pjmedia_tp_proto.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pjmedia_tp_proto ret = new SWIGTYPE_p_pjmedia_tp_proto(pjsua2PINVOKE.StreamInfo_proto_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_pjmedia_dir dir {
    set {
      pjsua2PINVOKE.StreamInfo_dir_set(swigCPtr, SWIGTYPE_p_pjmedia_dir.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pjmedia_dir ret = new SWIGTYPE_p_pjmedia_dir(pjsua2PINVOKE.StreamInfo_dir_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_SocketAddress remoteRtpAddress {
    set {
      pjsua2PINVOKE.StreamInfo_remoteRtpAddress_set(swigCPtr, SWIGTYPE_p_SocketAddress.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_SocketAddress ret = new SWIGTYPE_p_SocketAddress(pjsua2PINVOKE.StreamInfo_remoteRtpAddress_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_SocketAddress remoteRtcpAddress {
    set {
      pjsua2PINVOKE.StreamInfo_remoteRtcpAddress_set(swigCPtr, SWIGTYPE_p_SocketAddress.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_SocketAddress ret = new SWIGTYPE_p_SocketAddress(pjsua2PINVOKE.StreamInfo_remoteRtcpAddress_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint txPt {
    set {
      pjsua2PINVOKE.StreamInfo_txPt_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.StreamInfo_txPt_get(swigCPtr);
      return ret;
    } 
  }

  public uint rxPt {
    set {
      pjsua2PINVOKE.StreamInfo_rxPt_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.StreamInfo_rxPt_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_string codecName {
    set {
      pjsua2PINVOKE.StreamInfo_codecName_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.StreamInfo_codecName_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint codecClockRate {
    set {
      pjsua2PINVOKE.StreamInfo_codecClockRate_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.StreamInfo_codecClockRate_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void codecParam {
    set {
      pjsua2PINVOKE.StreamInfo_codecParam_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.StreamInfo_codecParam_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public void fromPj(SWIGTYPE_p_pjsua_stream_info info) {
    pjsua2PINVOKE.StreamInfo_fromPj(swigCPtr, SWIGTYPE_p_pjsua_stream_info.getCPtr(info));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamInfo() : this(pjsua2PINVOKE.new_StreamInfo(), true) {
  }

}
