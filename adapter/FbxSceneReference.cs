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

public class FbxSceneReference : FbxObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxSceneReference(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxSceneReference_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxSceneReference obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static FbxClassId ClassId {
    set {
      fbx_wrapperPINVOKE.FbxSceneReference_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSceneReference_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxSceneReference_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxSceneReference Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSceneReference_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxSceneReference ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSceneReference(cPtr, false);
    return ret;
  }

  public new static FbxSceneReference Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSceneReference_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxSceneReference ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSceneReference(cPtr, false);
    return ret;
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t ReferenceFilePath {
    set {
      fbx_wrapperPINVOKE.FbxSceneReference_ReferenceFilePath_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSceneReference_ReferenceFilePath_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t ReferenceNameSpace {
    set {
      fbx_wrapperPINVOKE.FbxSceneReference_ReferenceNameSpace_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSceneReference_ReferenceNameSpace_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t ReferenceNodeName {
    set {
      fbx_wrapperPINVOKE.FbxSceneReference_ReferenceNodeName_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSceneReference_ReferenceNodeName_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_int_t ReferenceDepth {
    set {
      fbx_wrapperPINVOKE.FbxSceneReference_ReferenceDepth_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_int_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSceneReference_ReferenceDepth_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_int_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_int_t(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTBool IsLoaded {
    set {
      fbx_wrapperPINVOKE.FbxSceneReference_IsLoaded_set(swigCPtr, FbxPropertyTBool.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSceneReference_IsLoaded_get(swigCPtr);
      FbxPropertyTBool ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTBool(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTBool IsLocked {
    set {
      fbx_wrapperPINVOKE.FbxSceneReference_IsLocked_set(swigCPtr, FbxPropertyTBool.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSceneReference_IsLocked_get(swigCPtr);
      FbxPropertyTBool ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTBool(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTBool IsOriginalProxy {
    set {
      fbx_wrapperPINVOKE.FbxSceneReference_IsOriginalProxy_set(swigCPtr, FbxPropertyTBool.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSceneReference_IsOriginalProxy_get(swigCPtr);
      FbxPropertyTBool ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTBool(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTBool IsActiveProxy {
    set {
      fbx_wrapperPINVOKE.FbxSceneReference_IsActiveProxy_set(swigCPtr, FbxPropertyTBool.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSceneReference_IsActiveProxy_get(swigCPtr);
      FbxPropertyTBool ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTBool(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t ProxyManagerName {
    set {
      fbx_wrapperPINVOKE.FbxSceneReference_ProxyManagerName_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSceneReference_ProxyManagerName_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxString_t ProxyTag {
    set {
      fbx_wrapperPINVOKE.FbxSceneReference_ProxyTag_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxString_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSceneReference_ProxyTag_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxString_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxString_t(cPtr, false);
      return ret;
    } 
  }

}

}
