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

public class FbxAnimCurveKeyBase : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxAnimCurveKeyBase(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxAnimCurveKeyBase obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxAnimCurveKeyBase() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxAnimCurveKeyBase(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxTime mTime {
    set {
      fbx_wrapperPINVOKE.FbxAnimCurveKeyBase_mTime_set(swigCPtr, FbxTime.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxAnimCurveKeyBase_mTime_get(swigCPtr);
      FbxTime ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxTime(cPtr, false);
      return ret;
    } 
  }

  public FbxAnimCurveKeyBase() : this(fbx_wrapperPINVOKE.new_FbxAnimCurveKeyBase(), true) {
  }

  public virtual FbxTime GetTime() {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxAnimCurveKeyBase_GetTime(swigCPtr), true);
    return ret;
  }

  public virtual void SetTime(FbxTime pTime) {
    fbx_wrapperPINVOKE.FbxAnimCurveKeyBase_SetTime(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
