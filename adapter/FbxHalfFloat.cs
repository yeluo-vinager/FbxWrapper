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

public class FbxHalfFloat : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxHalfFloat(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxHalfFloat obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxHalfFloat() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxHalfFloat(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxHalfFloat() : this(fbx_wrapperPINVOKE.new_FbxHalfFloat__SWIG_0(), true) {
  }

  public FbxHalfFloat(float pVal) : this(fbx_wrapperPINVOKE.new_FbxHalfFloat__SWIG_1(pVal), true) {
  }

  public FbxHalfFloat(FbxHalfFloat pVal) : this(fbx_wrapperPINVOKE.new_FbxHalfFloat__SWIG_2(FbxHalfFloat.getCPtr(pVal)), true) {
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
  }

  public FbxHalfFloat assign(FbxHalfFloat pValue) {
    FbxHalfFloat ret = new FbxHalfFloat(fbx_wrapperPINVOKE.FbxHalfFloat_assign(swigCPtr, FbxHalfFloat.getCPtr(pValue)), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool eq(FbxHalfFloat pRHS) {
    bool ret = fbx_wrapperPINVOKE.FbxHalfFloat_eq(swigCPtr, FbxHalfFloat.getCPtr(pRHS));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ne(FbxHalfFloat pRHS) {
    bool ret = fbx_wrapperPINVOKE.FbxHalfFloat_ne(swigCPtr, FbxHalfFloat.getCPtr(pRHS));
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float value() {
    float ret = fbx_wrapperPINVOKE.FbxHalfFloat_value(swigCPtr);
    return ret;
  }

}

}
