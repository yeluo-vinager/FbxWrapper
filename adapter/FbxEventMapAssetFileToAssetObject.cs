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

public class FbxEventMapAssetFileToAssetObject : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxEventMapAssetFileToAssetObject(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxEventMapAssetFileToAssetObject obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxEventMapAssetFileToAssetObject() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fbx_wrapperPINVOKE.delete_FbxEventMapAssetFileToAssetObject(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual string GetEventName() {
    string ret = fbx_wrapperPINVOKE.FbxEventMapAssetFileToAssetObject_GetEventName(swigCPtr);
    return ret;
  }

  public FbxEventMapAssetFileToAssetObject(string pFile) : this(fbx_wrapperPINVOKE.new_FbxEventMapAssetFileToAssetObject(pFile), true) {
  }

  public string GetFilePath() {
    string ret = fbx_wrapperPINVOKE.FbxEventMapAssetFileToAssetObject_GetFilePath(swigCPtr);
    return ret;
  }

  public FbxObject mAsset {
    set {
      fbx_wrapperPINVOKE.FbxEventMapAssetFileToAssetObject_mAsset_set(swigCPtr, FbxObject.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxEventMapAssetFileToAssetObject_mAsset_get(swigCPtr);
      FbxObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxObject(cPtr, false);
      return ret;
    } 
  }

}

}