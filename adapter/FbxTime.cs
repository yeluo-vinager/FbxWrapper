//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Fbx {

public class FbxTime : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxTime(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxTime obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxTime() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxTime(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxTime(SWIGTYPE_p_signed___int64 pTime) : this(fbx_wrapperPINVOKE.new_FbxTime__SWIG_0(SWIGTYPE_p_signed___int64.getCPtr(pTime)), true) {
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxTime() : this(fbx_wrapperPINVOKE.new_FbxTime__SWIG_1(), true) {
  }

  public static void SetGlobalTimeMode(FbxTime.EMode pTimeMode, double pFrameRate) {
    fbx_wrapperPINVOKE.FbxTime_SetGlobalTimeMode__SWIG_0((int)pTimeMode, pFrameRate);
  }

  public static void SetGlobalTimeMode(FbxTime.EMode pTimeMode) {
    fbx_wrapperPINVOKE.FbxTime_SetGlobalTimeMode__SWIG_1((int)pTimeMode);
  }

  public static FbxTime.EMode GetGlobalTimeMode() {
    FbxTime.EMode ret = (FbxTime.EMode)fbx_wrapperPINVOKE.FbxTime_GetGlobalTimeMode();
    return ret;
  }

  public static void SetGlobalTimeProtocol(FbxTime.EProtocol pTimeProtocol) {
    fbx_wrapperPINVOKE.FbxTime_SetGlobalTimeProtocol((int)pTimeProtocol);
  }

  public static FbxTime.EProtocol GetGlobalTimeProtocol() {
    FbxTime.EProtocol ret = (FbxTime.EProtocol)fbx_wrapperPINVOKE.FbxTime_GetGlobalTimeProtocol();
    return ret;
  }

  public static double GetFrameRate(FbxTime.EMode pTimeMode) {
    double ret = fbx_wrapperPINVOKE.FbxTime_GetFrameRate((int)pTimeMode);
    return ret;
  }

  public static FbxTime.EMode ConvertFrameRateToTimeMode(double pFrameRate, double pPrecision) {
    FbxTime.EMode ret = (FbxTime.EMode)fbx_wrapperPINVOKE.FbxTime_ConvertFrameRateToTimeMode__SWIG_0(pFrameRate, pPrecision);
    return ret;
  }

  public static FbxTime.EMode ConvertFrameRateToTimeMode(double pFrameRate) {
    FbxTime.EMode ret = (FbxTime.EMode)fbx_wrapperPINVOKE.FbxTime_ConvertFrameRateToTimeMode__SWIG_1(pFrameRate);
    return ret;
  }

  public void Set(SWIGTYPE_p_signed___int64 pTime) {
    fbx_wrapperPINVOKE.FbxTime_Set(swigCPtr, SWIGTYPE_p_signed___int64.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_signed___int64 Get() {
    SWIGTYPE_p_signed___int64 ret = new SWIGTYPE_p_signed___int64(fbx_wrapperPINVOKE.FbxTime_Get(swigCPtr), true);
    return ret;
  }

  public void SetMilliSeconds(SWIGTYPE_p_signed___int64 pMilliSeconds) {
    fbx_wrapperPINVOKE.FbxTime_SetMilliSeconds(swigCPtr, SWIGTYPE_p_signed___int64.getCPtr(pMilliSeconds));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_signed___int64 GetMilliSeconds() {
    SWIGTYPE_p_signed___int64 ret = new SWIGTYPE_p_signed___int64(fbx_wrapperPINVOKE.FbxTime_GetMilliSeconds(swigCPtr), true);
    return ret;
  }

  public void SetSecondDouble(double pTime) {
    fbx_wrapperPINVOKE.FbxTime_SetSecondDouble(swigCPtr, pTime);
  }

  public double GetSecondDouble() {
    double ret = fbx_wrapperPINVOKE.FbxTime_GetSecondDouble(swigCPtr);
    return ret;
  }

  public void SetTime(int pHour, int pMinute, int pSecond, int pFrame, int pField, FbxTime.EMode pTimeMode) {
    fbx_wrapperPINVOKE.FbxTime_SetTime__SWIG_0(swigCPtr, pHour, pMinute, pSecond, pFrame, pField, (int)pTimeMode);
  }

  public void SetTime(int pHour, int pMinute, int pSecond, int pFrame, int pField) {
    fbx_wrapperPINVOKE.FbxTime_SetTime__SWIG_1(swigCPtr, pHour, pMinute, pSecond, pFrame, pField);
  }

  public void SetTime(int pHour, int pMinute, int pSecond, int pFrame) {
    fbx_wrapperPINVOKE.FbxTime_SetTime__SWIG_2(swigCPtr, pHour, pMinute, pSecond, pFrame);
  }

  public void SetTime(int pHour, int pMinute, int pSecond) {
    fbx_wrapperPINVOKE.FbxTime_SetTime__SWIG_3(swigCPtr, pHour, pMinute, pSecond);
  }

  public void SetTime(int pHour, int pMinute, int pSecond, int pFrame, int pField, int pResidual, FbxTime.EMode pTimeMode) {
    fbx_wrapperPINVOKE.FbxTime_SetTime__SWIG_4(swigCPtr, pHour, pMinute, pSecond, pFrame, pField, pResidual, (int)pTimeMode);
  }

  public bool GetTime(SWIGTYPE_p_int pHour, SWIGTYPE_p_int pMinute, SWIGTYPE_p_int pSecond, SWIGTYPE_p_int pFrame, SWIGTYPE_p_int pField, SWIGTYPE_p_int pResidual, FbxTime.EMode pTimeMode) {
    bool ret = fbx_wrapperPINVOKE.FbxTime_GetTime__SWIG_0(swigCPtr, SWIGTYPE_p_int.getCPtr(pHour), SWIGTYPE_p_int.getCPtr(pMinute), SWIGTYPE_p_int.getCPtr(pSecond), SWIGTYPE_p_int.getCPtr(pFrame), SWIGTYPE_p_int.getCPtr(pField), SWIGTYPE_p_int.getCPtr(pResidual), (int)pTimeMode);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetTime(SWIGTYPE_p_int pHour, SWIGTYPE_p_int pMinute, SWIGTYPE_p_int pSecond, SWIGTYPE_p_int pFrame, SWIGTYPE_p_int pField, SWIGTYPE_p_int pResidual) {
    bool ret = fbx_wrapperPINVOKE.FbxTime_GetTime__SWIG_1(swigCPtr, SWIGTYPE_p_int.getCPtr(pHour), SWIGTYPE_p_int.getCPtr(pMinute), SWIGTYPE_p_int.getCPtr(pSecond), SWIGTYPE_p_int.getCPtr(pFrame), SWIGTYPE_p_int.getCPtr(pField), SWIGTYPE_p_int.getCPtr(pResidual));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxTime GetFramedTime(bool pRound) {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxTime_GetFramedTime__SWIG_0(swigCPtr, pRound), true);
    return ret;
  }

  public FbxTime GetFramedTime() {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxTime_GetFramedTime__SWIG_1(swigCPtr), true);
    return ret;
  }

  public void SetFrame(SWIGTYPE_p_signed___int64 pFrames, FbxTime.EMode pTimeMode) {
    fbx_wrapperPINVOKE.FbxTime_SetFrame__SWIG_0(swigCPtr, SWIGTYPE_p_signed___int64.getCPtr(pFrames), (int)pTimeMode);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetFrame(SWIGTYPE_p_signed___int64 pFrames) {
    fbx_wrapperPINVOKE.FbxTime_SetFrame__SWIG_1(swigCPtr, SWIGTYPE_p_signed___int64.getCPtr(pFrames));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetFramePrecise(double pFrames, FbxTime.EMode pTimeMode) {
    fbx_wrapperPINVOKE.FbxTime_SetFramePrecise__SWIG_0(swigCPtr, pFrames, (int)pTimeMode);
  }

  public void SetFramePrecise(double pFrames) {
    fbx_wrapperPINVOKE.FbxTime_SetFramePrecise__SWIG_1(swigCPtr, pFrames);
  }

  public int GetHourCount() {
    int ret = fbx_wrapperPINVOKE.FbxTime_GetHourCount(swigCPtr);
    return ret;
  }

  public int GetMinuteCount() {
    int ret = fbx_wrapperPINVOKE.FbxTime_GetMinuteCount(swigCPtr);
    return ret;
  }

  public int GetSecondCount() {
    int ret = fbx_wrapperPINVOKE.FbxTime_GetSecondCount(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_signed___int64 GetFrameCount(FbxTime.EMode pTimeMode) {
    SWIGTYPE_p_signed___int64 ret = new SWIGTYPE_p_signed___int64(fbx_wrapperPINVOKE.FbxTime_GetFrameCount__SWIG_0(swigCPtr, (int)pTimeMode), true);
    return ret;
  }

  public SWIGTYPE_p_signed___int64 GetFrameCount() {
    SWIGTYPE_p_signed___int64 ret = new SWIGTYPE_p_signed___int64(fbx_wrapperPINVOKE.FbxTime_GetFrameCount__SWIG_1(swigCPtr), true);
    return ret;
  }

  public double GetFrameCountPrecise(FbxTime.EMode pTimeMode) {
    double ret = fbx_wrapperPINVOKE.FbxTime_GetFrameCountPrecise__SWIG_0(swigCPtr, (int)pTimeMode);
    return ret;
  }

  public double GetFrameCountPrecise() {
    double ret = fbx_wrapperPINVOKE.FbxTime_GetFrameCountPrecise__SWIG_1(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_signed___int64 GetFieldCount(FbxTime.EMode pTimeMode) {
    SWIGTYPE_p_signed___int64 ret = new SWIGTYPE_p_signed___int64(fbx_wrapperPINVOKE.FbxTime_GetFieldCount__SWIG_0(swigCPtr, (int)pTimeMode), true);
    return ret;
  }

  public SWIGTYPE_p_signed___int64 GetFieldCount() {
    SWIGTYPE_p_signed___int64 ret = new SWIGTYPE_p_signed___int64(fbx_wrapperPINVOKE.FbxTime_GetFieldCount__SWIG_1(swigCPtr), true);
    return ret;
  }

  public int GetResidual(FbxTime.EMode pTimeMode) {
    int ret = fbx_wrapperPINVOKE.FbxTime_GetResidual__SWIG_0(swigCPtr, (int)pTimeMode);
    return ret;
  }

  public int GetResidual() {
    int ret = fbx_wrapperPINVOKE.FbxTime_GetResidual__SWIG_1(swigCPtr);
    return ret;
  }

  public static bool IsDropFrame(FbxTime.EMode pTimeMode) {
    bool ret = fbx_wrapperPINVOKE.FbxTime_IsDropFrame__SWIG_0((int)pTimeMode);
    return ret;
  }

  public static bool IsDropFrame() {
    bool ret = fbx_wrapperPINVOKE.FbxTime_IsDropFrame__SWIG_1();
    return ret;
  }

  public char GetFrameSeparator(FbxTime.EMode pTimeMode) {
    char ret = fbx_wrapperPINVOKE.FbxTime_GetFrameSeparator__SWIG_0(swigCPtr, (int)pTimeMode);
    return ret;
  }

  public char GetFrameSeparator() {
    char ret = fbx_wrapperPINVOKE.FbxTime_GetFrameSeparator__SWIG_1(swigCPtr);
    return ret;
  }

  public string GetTimeString(string pTimeString, ushort pTimeStringSize, int pInfo, FbxTime.EMode pTimeMode, FbxTime.EProtocol pTimeFormat) {
    string ret = fbx_wrapperPINVOKE.FbxTime_GetTimeString__SWIG_0(swigCPtr, pTimeString, pTimeStringSize, pInfo, (int)pTimeMode, (int)pTimeFormat);
    return ret;
  }

  public string GetTimeString(string pTimeString, ushort pTimeStringSize, int pInfo, FbxTime.EMode pTimeMode) {
    string ret = fbx_wrapperPINVOKE.FbxTime_GetTimeString__SWIG_1(swigCPtr, pTimeString, pTimeStringSize, pInfo, (int)pTimeMode);
    return ret;
  }

  public string GetTimeString(string pTimeString, ushort pTimeStringSize, int pInfo) {
    string ret = fbx_wrapperPINVOKE.FbxTime_GetTimeString__SWIG_2(swigCPtr, pTimeString, pTimeStringSize, pInfo);
    return ret;
  }

  public string GetTimeString(string pTimeString, ushort pTimeStringSize) {
    string ret = fbx_wrapperPINVOKE.FbxTime_GetTimeString__SWIG_3(swigCPtr, pTimeString, pTimeStringSize);
    return ret;
  }

  public FbxString GetTimeString(FbxTime.EElement pStart, FbxTime.EElement pEnd, FbxTime.EMode pTimeMode, FbxTime.EProtocol pTimeFormat) {
    FbxString ret = new FbxString(fbx_wrapperPINVOKE.FbxTime_GetTimeString__SWIG_4(swigCPtr, (int)pStart, (int)pEnd, (int)pTimeMode, (int)pTimeFormat), true);
    return ret;
  }

  public FbxString GetTimeString(FbxTime.EElement pStart, FbxTime.EElement pEnd, FbxTime.EMode pTimeMode) {
    FbxString ret = new FbxString(fbx_wrapperPINVOKE.FbxTime_GetTimeString__SWIG_5(swigCPtr, (int)pStart, (int)pEnd, (int)pTimeMode), true);
    return ret;
  }

  public FbxString GetTimeString(FbxTime.EElement pStart, FbxTime.EElement pEnd) {
    FbxString ret = new FbxString(fbx_wrapperPINVOKE.FbxTime_GetTimeString__SWIG_6(swigCPtr, (int)pStart, (int)pEnd), true);
    return ret;
  }

  public FbxString GetTimeString(FbxTime.EElement pStart) {
    FbxString ret = new FbxString(fbx_wrapperPINVOKE.FbxTime_GetTimeString__SWIG_7(swigCPtr, (int)pStart), true);
    return ret;
  }

  public FbxString GetTimeString() {
    FbxString ret = new FbxString(fbx_wrapperPINVOKE.FbxTime_GetTimeString__SWIG_8(swigCPtr), true);
    return ret;
  }

  public bool SetTimeString(string pTime, FbxTime.EMode pTimeMode, FbxTime.EProtocol pTimeFormat) {
    bool ret = fbx_wrapperPINVOKE.FbxTime_SetTimeString__SWIG_0(swigCPtr, pTime, (int)pTimeMode, (int)pTimeFormat);
    return ret;
  }

  public bool SetTimeString(string pTime, FbxTime.EMode pTimeMode) {
    bool ret = fbx_wrapperPINVOKE.FbxTime_SetTimeString__SWIG_1(swigCPtr, pTime, (int)pTimeMode);
    return ret;
  }

  public bool SetTimeString(string pTime) {
    bool ret = fbx_wrapperPINVOKE.FbxTime_SetTimeString__SWIG_2(swigCPtr, pTime);
    return ret;
  }

  public bool eq(FbxTime pTime) {
    bool ret = fbx_wrapperPINVOKE.FbxTime_eq(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ne(FbxTime pTime) {
    bool ret = fbx_wrapperPINVOKE.FbxTime_ne(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gte(FbxTime pTime) {
    bool ret = fbx_wrapperPINVOKE.FbxTime_gte(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool lte(FbxTime pTime) {
    bool ret = fbx_wrapperPINVOKE.FbxTime_lte(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool gt(FbxTime pTime) {
    bool ret = fbx_wrapperPINVOKE.FbxTime_gt(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool lt(FbxTime pTime) {
    bool ret = fbx_wrapperPINVOKE.FbxTime_lt(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxTime assign(FbxTime pTime) {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxTime_assign(swigCPtr, FbxTime.getCPtr(pTime)), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxTime add_assign(FbxTime pTime) {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxTime_add_assign(swigCPtr, FbxTime.getCPtr(pTime)), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxTime sub_assign(FbxTime pTime) {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxTime_sub_assign(swigCPtr, FbxTime.getCPtr(pTime)), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxTime add(FbxTime pTime) {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxTime_add(swigCPtr, FbxTime.getCPtr(pTime)), true);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxTime sub(FbxTime pTime) {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxTime_sub(swigCPtr, FbxTime.getCPtr(pTime)), true);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxTime mul(int Mult) {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxTime_mul__SWIG_0(swigCPtr, Mult), true);
    return ret;
  }

  public FbxTime div(FbxTime pTime) {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxTime_div(swigCPtr, FbxTime.getCPtr(pTime)), true);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxTime mul(FbxTime pTime) {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxTime_mul__SWIG_1(swigCPtr, FbxTime.getCPtr(pTime)), true);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static SWIGTYPE_p_signed___int64 GetOneFrameValue(FbxTime.EMode pTimeMode) {
    SWIGTYPE_p_signed___int64 ret = new SWIGTYPE_p_signed___int64(fbx_wrapperPINVOKE.FbxTime_GetOneFrameValue__SWIG_0((int)pTimeMode), true);
    return ret;
  }

  public static SWIGTYPE_p_signed___int64 GetOneFrameValue() {
    SWIGTYPE_p_signed___int64 ret = new SWIGTYPE_p_signed___int64(fbx_wrapperPINVOKE.FbxTime_GetOneFrameValue__SWIG_1(), true);
    return ret;
  }

  public enum EMode {
    eDefaultMode,
    eFrames120,
    eFrames100,
    eFrames60,
    eFrames50,
    eFrames48,
    eFrames30,
    eFrames30Drop,
    eNTSCDropFrame,
    eNTSCFullFrame,
    ePAL,
    eFrames24,
    eFrames1000,
    eFilmFullFrame,
    eCustom,
    eFrames96,
    eFrames72,
    eFrames59dot94,
    eModesCount
  }

  public enum EProtocol {
    eSMPTE,
    eFrameCount,
    eDefaultProtocol
  }

  public enum EElement {
    eHours,
    eMinutes,
    eSeconds,
    eFrames,
    eField,
    eResidual
  }

  public enum EOldMode {
    eOLD_DEFAULT_MODE,
    eOLD_CINEMA,
    eOLD_PAL,
    eOLD_FRAMES30,
    eOLD_NTSC_DROP_FRAME,
    eOLD_FRAMES50,
    eOLD_FRAMES60,
    eOLD_FRAMES100,
    eOLD_FRAMES120,
    eOLD_NTSC_FULL_FRAME,
    eOLD_FRAMES30_DROP,
    eOLD_FRAMES1000
  }

}

}