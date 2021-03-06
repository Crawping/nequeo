//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TlsConfig : PersistentObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal TlsConfig(global::System.IntPtr cPtr, bool cMemoryOwn) : base(pjsua2PINVOKE.TlsConfig_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TlsConfig obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TlsConfig() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_TlsConfig(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public SWIGTYPE_p_string CaListFile {
    set {
      pjsua2PINVOKE.TlsConfig_CaListFile_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.TlsConfig_CaListFile_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_string certFile {
    set {
      pjsua2PINVOKE.TlsConfig_certFile_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.TlsConfig_certFile_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_string privKeyFile {
    set {
      pjsua2PINVOKE.TlsConfig_privKeyFile_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.TlsConfig_privKeyFile_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_string password {
    set {
      pjsua2PINVOKE.TlsConfig_password_set(swigCPtr, SWIGTYPE_p_string.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.TlsConfig_password_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_pjsip_ssl_method method {
    set {
      pjsua2PINVOKE.TlsConfig_method_set(swigCPtr, SWIGTYPE_p_pjsip_ssl_method.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pjsip_ssl_method ret = new SWIGTYPE_p_pjsip_ssl_method(pjsua2PINVOKE.TlsConfig_method_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public uint proto {
    set {
      pjsua2PINVOKE.TlsConfig_proto_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.TlsConfig_proto_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_IntVector ciphers {
    set {
      pjsua2PINVOKE.TlsConfig_ciphers_set(swigCPtr, SWIGTYPE_p_IntVector.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_IntVector ret = new SWIGTYPE_p_IntVector(pjsua2PINVOKE.TlsConfig_ciphers_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool verifyServer {
    set {
      pjsua2PINVOKE.TlsConfig_verifyServer_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.TlsConfig_verifyServer_get(swigCPtr);
      return ret;
    } 
  }

  public bool verifyClient {
    set {
      pjsua2PINVOKE.TlsConfig_verifyClient_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.TlsConfig_verifyClient_get(swigCPtr);
      return ret;
    } 
  }

  public bool requireClientCert {
    set {
      pjsua2PINVOKE.TlsConfig_requireClientCert_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.TlsConfig_requireClientCert_get(swigCPtr);
      return ret;
    } 
  }

  public uint msecTimeout {
    set {
      pjsua2PINVOKE.TlsConfig_msecTimeout_set(swigCPtr, value);
    } 
    get {
      uint ret = pjsua2PINVOKE.TlsConfig_msecTimeout_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_pj_qos_type qosType {
    set {
      pjsua2PINVOKE.TlsConfig_qosType_set(swigCPtr, SWIGTYPE_p_pj_qos_type.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pj_qos_type ret = new SWIGTYPE_p_pj_qos_type(pjsua2PINVOKE.TlsConfig_qosType_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_pj_qos_params qosParams {
    set {
      pjsua2PINVOKE.TlsConfig_qosParams_set(swigCPtr, SWIGTYPE_p_pj_qos_params.getCPtr(value));
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_pj_qos_params ret = new SWIGTYPE_p_pj_qos_params(pjsua2PINVOKE.TlsConfig_qosParams_get(swigCPtr), true);
      if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public bool qosIgnoreError {
    set {
      pjsua2PINVOKE.TlsConfig_qosIgnoreError_set(swigCPtr, value);
    } 
    get {
      bool ret = pjsua2PINVOKE.TlsConfig_qosIgnoreError_get(swigCPtr);
      return ret;
    } 
  }

  public TlsConfig() : this(pjsua2PINVOKE.new_TlsConfig(), true) {
  }

  public SWIGTYPE_p_pjsip_tls_setting toPj() {
    SWIGTYPE_p_pjsip_tls_setting ret = new SWIGTYPE_p_pjsip_tls_setting(pjsua2PINVOKE.TlsConfig_toPj(swigCPtr), true);
    return ret;
  }

  public void fromPj(SWIGTYPE_p_pjsip_tls_setting prm) {
    pjsua2PINVOKE.TlsConfig_fromPj(swigCPtr, SWIGTYPE_p_pjsip_tls_setting.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public override void readObject(ContainerNode node) {
    pjsua2PINVOKE.TlsConfig_readObject(swigCPtr, ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public override void writeObject(ContainerNode node) {
    pjsua2PINVOKE.TlsConfig_writeObject(swigCPtr, ContainerNode.getCPtr(node));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

}
