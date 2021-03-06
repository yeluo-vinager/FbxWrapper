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

public class FbxTimeSpan : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxTimeSpan(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxTimeSpan obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxTimeSpan() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxTimeSpan(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxTimeSpan() : this(fbx_wrapperPINVOKE.new_FbxTimeSpan__SWIG_0(), true) {
  }

  public FbxTimeSpan(FbxTime pStart, FbxTime pStop) : this(fbx_wrapperPINVOKE.new_FbxTimeSpan__SWIG_1(FbxTime.getCPtr(pStart), FbxTime.getCPtr(pStop)), true) {
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Set(FbxTime pStart, FbxTime pStop) {
    fbx_wrapperPINVOKE.FbxTimeSpan_Set(swigCPtr, FbxTime.getCPtr(pStart), FbxTime.getCPtr(pStop));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetStart(FbxTime pStart) {
    fbx_wrapperPINVOKE.FbxTimeSpan_SetStart(swigCPtr, FbxTime.getCPtr(pStart));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetStop(FbxTime pStop) {
    fbx_wrapperPINVOKE.FbxTimeSpan_SetStop(swigCPtr, FbxTime.getCPtr(pStop));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxTime GetStart() {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxTimeSpan_GetStart(swigCPtr), true);
    return ret;
  }

  public FbxTime GetStop() {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxTimeSpan_GetStop(swigCPtr), true);
    return ret;
  }

  public FbxTime GetDuration() {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxTimeSpan_GetDuration(swigCPtr), true);
    return ret;
  }

  public FbxTime GetSignedDuration() {
    FbxTime ret = new FbxTime(fbx_wrapperPINVOKE.FbxTimeSpan_GetSignedDuration(swigCPtr), true);
    return ret;
  }

  public int GetDirection() {
    int ret = fbx_wrapperPINVOKE.FbxTimeSpan_GetDirection(swigCPtr);
    return ret;
  }

  public bool IsInside(FbxTime pTime) {
    bool ret = fbx_wrapperPINVOKE.FbxTimeSpan_IsInside(swigCPtr, FbxTime.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxTimeSpan Intersect(FbxTimeSpan pTime) {
    FbxTimeSpan ret = new FbxTimeSpan(fbx_wrapperPINVOKE.FbxTimeSpan_Intersect(swigCPtr, FbxTimeSpan.getCPtr(pTime)), true);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ne(FbxTimeSpan pTime) {
    bool ret = fbx_wrapperPINVOKE.FbxTimeSpan_ne(swigCPtr, FbxTimeSpan.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool eq(FbxTimeSpan pTime) {
    bool ret = fbx_wrapperPINVOKE.FbxTimeSpan_eq(swigCPtr, FbxTimeSpan.getCPtr(pTime));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void UnionAssignment(FbxTimeSpan pSpan, int pDirection) {
    fbx_wrapperPINVOKE.FbxTimeSpan_UnionAssignment__SWIG_0(swigCPtr, FbxTimeSpan.getCPtr(pSpan), pDirection);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public void UnionAssignment(FbxTimeSpan pSpan) {
    fbx_wrapperPINVOKE.FbxTimeSpan_UnionAssignment__SWIG_1(swigCPtr, FbxTimeSpan.getCPtr(pSpan));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
