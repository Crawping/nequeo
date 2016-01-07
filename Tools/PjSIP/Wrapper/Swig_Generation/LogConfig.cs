//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class LogConfig : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal LogConfig(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(LogConfig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~LogConfig() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_LogConfig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public uint msgLogging {
    set {
      pjsua2PINVOKE.LogConfig_msgLogging_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.LogConfig_msgLogging_get(swigCPtr);
      return ret;
    } 
  }

  public uint level {
    set {
      pjsua2PINVOKE.LogConfig_level_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.LogConfig_level_get(swigCPtr);
      return ret;
    } 
  }

  public uint consoleLevel {
    set {
      pjsua2PINVOKE.LogConfig_consoleLevel_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.LogConfig_consoleLevel_get(swigCPtr);
      return ret;
    } 
  }

  public uint decor {
    set {
      pjsua2PINVOKE.LogConfig_decor_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.LogConfig_decor_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_string filename {
    set {
      pjsua2PINVOKE.LogConfig_filename_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.LogConfig_filename_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint fileFlags {
    set {
      pjsua2PINVOKE.LogConfig_fileFlags_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.LogConfig_fileFlags_get(swigCPtr);
      return ret;
    } 
  }

  public LogWriter writer {
    set {
      pjsua2PINVOKE.LogConfig_writer_set(swigCPtr, LogWriter.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = pjsua2PINVOKE.LogConfig_writer_get(swigCPtr);
      LogWriter ret = (cPtr == global::System.IntPtr.Zero) ? null : new LogWriter(cPtr, false);
      return ret;
    } 
  }

  public LogConfig() : this(pjsua2PINVOKE.new_LogConfig(), true) {
  }

  public void fromPj(SWIGTYPE_p_pjsua_logging_config lc) {
    pjsua2PINVOKE.LogConfig_fromPj(swigCPtr, SWIGTYPE_p_pjsua_logging_config.getCPtr(lc));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_pjsua_logging_config toPj() {
    SWIGTYPE_p_pjsua_logging_config ret = new SWIGTYPE_p_pjsua_logging_config(pjsua2PINVOKE.LogConfig_toPj(swigCPtr), true);
    return ret;
  }

  public virtual void readObject(SWIGTYPE_p_ContainerNode node) {
    pjsua2PINVOKE.LogConfig_readObject(swigCPtr, SWIGTYPE_p_ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void writeObject(SWIGTYPE_p_ContainerNode node) {
    pjsua2PINVOKE.LogConfig_writeObject(swigCPtr, SWIGTYPE_p_ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

}
