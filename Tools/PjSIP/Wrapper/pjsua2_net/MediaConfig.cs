/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace pjsua2 {

public class MediaConfig : PersistentObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MediaConfig(global::System.IntPtr cPtr, bool cMemoryOwn) : base(pjsua2PINVOKE.MediaConfig_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MediaConfig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MediaConfig() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_MediaConfig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public uint clockRate {
    set {
      pjsua2PINVOKE.MediaConfig_clockRate_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaConfig_clockRate_get(swigCPtr);
      return ret;
    } 
  }

  public uint sndClockRate {
    set {
      pjsua2PINVOKE.MediaConfig_sndClockRate_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaConfig_sndClockRate_get(swigCPtr);
      return ret;
    } 
  }

  public uint channelCount {
    set {
      pjsua2PINVOKE.MediaConfig_channelCount_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaConfig_channelCount_get(swigCPtr);
      return ret;
    } 
  }

  public uint audioFramePtime {
    set {
      pjsua2PINVOKE.MediaConfig_audioFramePtime_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaConfig_audioFramePtime_get(swigCPtr);
      return ret;
    } 
  }

  public uint maxMediaPorts {
    set {
      pjsua2PINVOKE.MediaConfig_maxMediaPorts_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaConfig_maxMediaPorts_get(swigCPtr);
      return ret;
    } 
  }

  public bool hasIoqueue {
    set {
      pjsua2PINVOKE.MediaConfig_hasIoqueue_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.MediaConfig_hasIoqueue_get(swigCPtr);
      return ret;
    } 
  }

  public uint threadCnt {
    set {
      pjsua2PINVOKE.MediaConfig_threadCnt_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaConfig_threadCnt_get(swigCPtr);
      return ret;
    } 
  }

  public uint quality {
    set {
      pjsua2PINVOKE.MediaConfig_quality_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaConfig_quality_get(swigCPtr);
      return ret;
    } 
  }

  public uint ptime {
    set {
      pjsua2PINVOKE.MediaConfig_ptime_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaConfig_ptime_get(swigCPtr);
      return ret;
    } 
  }

  public bool noVad {
    set {
      pjsua2PINVOKE.MediaConfig_noVad_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.MediaConfig_noVad_get(swigCPtr);
      return ret;
    } 
  }

  public uint ilbcMode {
    set {
      pjsua2PINVOKE.MediaConfig_ilbcMode_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaConfig_ilbcMode_get(swigCPtr);
      return ret;
    } 
  }

  public uint txDropPct {
    set {
      pjsua2PINVOKE.MediaConfig_txDropPct_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaConfig_txDropPct_get(swigCPtr);
      return ret;
    } 
  }

  public uint rxDropPct {
    set {
      pjsua2PINVOKE.MediaConfig_rxDropPct_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaConfig_rxDropPct_get(swigCPtr);
      return ret;
    } 
  }

  public uint ecOptions {
    set {
      pjsua2PINVOKE.MediaConfig_ecOptions_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaConfig_ecOptions_get(swigCPtr);
      return ret;
    } 
  }

  public uint ecTailLen {
    set {
      pjsua2PINVOKE.MediaConfig_ecTailLen_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaConfig_ecTailLen_get(swigCPtr);
      return ret;
    } 
  }

  public uint sndRecLatency {
    set {
      pjsua2PINVOKE.MediaConfig_sndRecLatency_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaConfig_sndRecLatency_get(swigCPtr);
      return ret;
    } 
  }

  public uint sndPlayLatency {
    set {
      pjsua2PINVOKE.MediaConfig_sndPlayLatency_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.MediaConfig_sndPlayLatency_get(swigCPtr);
      return ret;
    } 
  }

  public int jbInit {
    set {
      pjsua2PINVOKE.MediaConfig_jbInit_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.MediaConfig_jbInit_get(swigCPtr);
      return ret;
    } 
  }

  public int jbMinPre {
    set {
      pjsua2PINVOKE.MediaConfig_jbMinPre_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.MediaConfig_jbMinPre_get(swigCPtr);
      return ret;
    } 
  }

  public int jbMaxPre {
    set {
      pjsua2PINVOKE.MediaConfig_jbMaxPre_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.MediaConfig_jbMaxPre_get(swigCPtr);
      return ret;
    } 
  }

  public int jbMax {
    set {
      pjsua2PINVOKE.MediaConfig_jbMax_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.MediaConfig_jbMax_get(swigCPtr);
      return ret;
    } 
  }

  public int sndAutoCloseTime {
    set {
      pjsua2PINVOKE.MediaConfig_sndAutoCloseTime_set(swigCPtr, value);
    } 
    get {
      int ret = pjsua2PINVOKE.MediaConfig_sndAutoCloseTime_get(swigCPtr);
      return ret;
    } 
  }

  public bool vidPreviewEnableNative {
    set {
      pjsua2PINVOKE.MediaConfig_vidPreviewEnableNative_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.MediaConfig_vidPreviewEnableNative_get(swigCPtr);
      return ret;
    } 
  }

  public MediaConfig() : this(pjsua2PINVOKE.new_MediaConfig(), true) {
  }

  public override void readObject(ContainerNode node) {
    pjsua2PINVOKE.MediaConfig_readObject(swigCPtr, ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public override void writeObject(ContainerNode node) {
    pjsua2PINVOKE.MediaConfig_writeObject(swigCPtr, ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

}

}
