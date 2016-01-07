//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Call : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Call(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Call obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Call() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          pjsua2PINVOKE.delete_Call(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public Call(Account acc, int call_id) : this(pjsua2PINVOKE.new_Call__SWIG_0(Account.getCPtr(acc), call_id), true) {
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public Call(Account acc) : this(pjsua2PINVOKE.new_Call__SWIG_1(Account.getCPtr(acc)), true) {
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public CallInfo getInfo() {
    CallInfo ret = new CallInfo(pjsua2PINVOKE.Call_getInfo(swigCPtr), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isActive() {
    bool ret = pjsua2PINVOKE.Call_isActive(swigCPtr);
    return ret;
  }

  public int getId() {
    int ret = pjsua2PINVOKE.Call_getId(swigCPtr);
    return ret;
  }

  public static Call lookup(int call_id) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.Call_lookup(call_id);
    Call ret = (cPtr == global::System.IntPtr.Zero) ? null : new Call(cPtr, false);
    return ret;
  }

  public bool hasMedia() {
    bool ret = pjsua2PINVOKE.Call_hasMedia(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_Media getMedia(uint med_idx) {
    global::System.IntPtr cPtr = pjsua2PINVOKE.Call_getMedia(swigCPtr, med_idx);
    SWIGTYPE_p_Media ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Media(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_pjsip_dialog_cap_status remoteHasCap(int htype, SWIGTYPE_p_string hname, SWIGTYPE_p_string token) {
    SWIGTYPE_p_pjsip_dialog_cap_status ret = new SWIGTYPE_p_pjsip_dialog_cap_status(pjsua2PINVOKE.Call_remoteHasCap(swigCPtr, htype, SWIGTYPE_p_string.getCPtr(hname), SWIGTYPE_p_string.getCPtr(token)), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setUserData(SWIGTYPE_p_Token user_data) {
    pjsua2PINVOKE.Call_setUserData(swigCPtr, SWIGTYPE_p_Token.getCPtr(user_data));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_Token getUserData() {
    SWIGTYPE_p_Token ret = new SWIGTYPE_p_Token(pjsua2PINVOKE.Call_getUserData(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_pj_stun_nat_type getRemNatType() {
    SWIGTYPE_p_pj_stun_nat_type ret = new SWIGTYPE_p_pj_stun_nat_type(pjsua2PINVOKE.Call_getRemNatType(swigCPtr), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void makeCall(SWIGTYPE_p_string dst_uri, CallOpParam prm) {
    pjsua2PINVOKE.Call_makeCall(swigCPtr, SWIGTYPE_p_string.getCPtr(dst_uri), CallOpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void answer(CallOpParam prm) {
    pjsua2PINVOKE.Call_answer(swigCPtr, CallOpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void hangup(CallOpParam prm) {
    pjsua2PINVOKE.Call_hangup(swigCPtr, CallOpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void setHold(CallOpParam prm) {
    pjsua2PINVOKE.Call_setHold(swigCPtr, CallOpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void reinvite(CallOpParam prm) {
    pjsua2PINVOKE.Call_reinvite(swigCPtr, CallOpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void update(CallOpParam prm) {
    pjsua2PINVOKE.Call_update(swigCPtr, CallOpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void xfer(SWIGTYPE_p_string dest, CallOpParam prm) {
    pjsua2PINVOKE.Call_xfer(swigCPtr, SWIGTYPE_p_string.getCPtr(dest), CallOpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void xferReplaces(Call dest_call, CallOpParam prm) {
    pjsua2PINVOKE.Call_xferReplaces(swigCPtr, Call.getCPtr(dest_call), CallOpParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void processRedirect(SWIGTYPE_p_pjsip_redirect_op cmd) {
    pjsua2PINVOKE.Call_processRedirect(swigCPtr, SWIGTYPE_p_pjsip_redirect_op.getCPtr(cmd));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void dialDtmf(SWIGTYPE_p_string digits) {
    pjsua2PINVOKE.Call_dialDtmf(swigCPtr, SWIGTYPE_p_string.getCPtr(digits));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void sendInstantMessage(SWIGTYPE_p_SendInstantMessageParam prm) {
    pjsua2PINVOKE.Call_sendInstantMessage(swigCPtr, SWIGTYPE_p_SendInstantMessageParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void sendTypingIndication(SWIGTYPE_p_SendTypingIndicationParam prm) {
    pjsua2PINVOKE.Call_sendTypingIndication(swigCPtr, SWIGTYPE_p_SendTypingIndicationParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void sendRequest(CallSendRequestParam prm) {
    pjsua2PINVOKE.Call_sendRequest(swigCPtr, CallSendRequestParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_string dump(bool with_media, SWIGTYPE_p_string indent) {
    SWIGTYPE_p_string ret = new SWIGTYPE_p_string(pjsua2PINVOKE.Call_dump(swigCPtr, with_media, SWIGTYPE_p_string.getCPtr(indent)), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int vidGetStreamIdx() {
    int ret = pjsua2PINVOKE.Call_vidGetStreamIdx(swigCPtr);
    return ret;
  }

  public bool vidStreamIsRunning(int med_idx, SWIGTYPE_p_pjmedia_dir dir) {
    bool ret = pjsua2PINVOKE.Call_vidStreamIsRunning(swigCPtr, med_idx, SWIGTYPE_p_pjmedia_dir.getCPtr(dir));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void vidSetStream(SWIGTYPE_p_pjsua_call_vid_strm_op op, CallVidSetStreamParam param) {
    pjsua2PINVOKE.Call_vidSetStream(swigCPtr, SWIGTYPE_p_pjsua_call_vid_strm_op.getCPtr(op), CallVidSetStreamParam.getCPtr(param));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public StreamInfo getStreamInfo(uint med_idx) {
    StreamInfo ret = new StreamInfo(pjsua2PINVOKE.Call_getStreamInfo(swigCPtr, med_idx), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public StreamStat getStreamStat(uint med_idx) {
    StreamStat ret = new StreamStat(pjsua2PINVOKE.Call_getStreamStat(swigCPtr, med_idx), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MediaTransportInfo getMedTransportInfo(uint med_idx) {
    MediaTransportInfo ret = new MediaTransportInfo(pjsua2PINVOKE.Call_getMedTransportInfo(swigCPtr, med_idx), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void processMediaUpdate(OnCallMediaStateParam prm) {
    pjsua2PINVOKE.Call_processMediaUpdate(swigCPtr, OnCallMediaStateParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public void processStateChange(OnCallStateParam prm) {
    pjsua2PINVOKE.Call_processStateChange(swigCPtr, OnCallStateParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallState(OnCallStateParam prm) {
    pjsua2PINVOKE.Call_onCallState(swigCPtr, OnCallStateParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallTsxState(OnCallTsxStateParam prm) {
    pjsua2PINVOKE.Call_onCallTsxState(swigCPtr, OnCallTsxStateParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallMediaState(OnCallMediaStateParam prm) {
    pjsua2PINVOKE.Call_onCallMediaState(swigCPtr, OnCallMediaStateParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallSdpCreated(OnCallSdpCreatedParam prm) {
    pjsua2PINVOKE.Call_onCallSdpCreated(swigCPtr, OnCallSdpCreatedParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onStreamCreated(OnStreamCreatedParam prm) {
    pjsua2PINVOKE.Call_onStreamCreated(swigCPtr, OnStreamCreatedParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onStreamDestroyed(OnStreamDestroyedParam prm) {
    pjsua2PINVOKE.Call_onStreamDestroyed(swigCPtr, OnStreamDestroyedParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onDtmfDigit(OnDtmfDigitParam prm) {
    pjsua2PINVOKE.Call_onDtmfDigit(swigCPtr, OnDtmfDigitParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallTransferRequest(OnCallTransferRequestParam prm) {
    pjsua2PINVOKE.Call_onCallTransferRequest(swigCPtr, OnCallTransferRequestParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallTransferStatus(OnCallTransferStatusParam prm) {
    pjsua2PINVOKE.Call_onCallTransferStatus(swigCPtr, OnCallTransferStatusParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallReplaceRequest(OnCallReplaceRequestParam prm) {
    pjsua2PINVOKE.Call_onCallReplaceRequest(swigCPtr, OnCallReplaceRequestParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallReplaced(OnCallReplacedParam prm) {
    pjsua2PINVOKE.Call_onCallReplaced(swigCPtr, OnCallReplacedParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallRxOffer(OnCallRxOfferParam prm) {
    pjsua2PINVOKE.Call_onCallRxOffer(swigCPtr, OnCallRxOfferParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onInstantMessage(OnInstantMessageParam prm) {
    pjsua2PINVOKE.Call_onInstantMessage(swigCPtr, OnInstantMessageParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onInstantMessageStatus(OnInstantMessageStatusParam prm) {
    pjsua2PINVOKE.Call_onInstantMessageStatus(swigCPtr, OnInstantMessageStatusParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onTypingIndication(OnTypingIndicationParam prm) {
    pjsua2PINVOKE.Call_onTypingIndication(swigCPtr, OnTypingIndicationParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_pjsip_redirect_op onCallRedirected(OnCallRedirectedParam prm) {
    SWIGTYPE_p_pjsip_redirect_op ret = new SWIGTYPE_p_pjsip_redirect_op(pjsua2PINVOKE.Call_onCallRedirected(swigCPtr, OnCallRedirectedParam.getCPtr(prm)), true);
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void onCallMediaTransportState(OnCallMediaTransportStateParam prm) {
    pjsua2PINVOKE.Call_onCallMediaTransportState(swigCPtr, OnCallMediaTransportStateParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCallMediaEvent(OnCallMediaEventParam prm) {
    pjsua2PINVOKE.Call_onCallMediaEvent(swigCPtr, OnCallMediaEventParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void onCreateMediaTransport(OnCreateMediaTransportParam prm) {
    pjsua2PINVOKE.Call_onCreateMediaTransport(swigCPtr, OnCreateMediaTransportParam.getCPtr(prm));
    if (pjsua2PINVOKE.SWIGPendingException.Pending) throw pjsua2PINVOKE.SWIGPendingException.Retrieve();
  }

}
