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

public class FbxNodeAttribute : FbxObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxNodeAttribute(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxNodeAttribute_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxNodeAttribute obj) {
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
      fbx_wrapperPINVOKE.FbxNodeAttribute_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxNodeAttribute_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxNodeAttribute_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxNodeAttribute Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxNodeAttribute_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxNodeAttribute ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNodeAttribute(cPtr, false);
    return ret;
  }

  public new static FbxNodeAttribute Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxNodeAttribute_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxNodeAttribute ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNodeAttribute(cPtr, false);
    return ret;
  }

  public static string sColor {
    set {
      fbx_wrapperPINVOKE.FbxNodeAttribute_sColor_set(value);
    } 
    get {
      string ret = fbx_wrapperPINVOKE.FbxNodeAttribute_sColor_get();
      return ret;
    } 
  }

  public static FbxDouble3 sDefaultColor {
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxNodeAttribute_sDefaultColor_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble3 Color {
    set {
      fbx_wrapperPINVOKE.FbxNodeAttribute_Color_set(swigCPtr, FbxPropertyTDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxNodeAttribute_Color_get(swigCPtr);
      FbxPropertyTDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble3(cPtr, false);
      return ret;
    } 
  }

  public virtual FbxNodeAttribute.EType GetAttributeType() {
    FbxNodeAttribute.EType ret = (FbxNodeAttribute.EType)fbx_wrapperPINVOKE.FbxNodeAttribute_GetAttributeType(swigCPtr);
    return ret;
  }

  public int GetNodeCount() {
    int ret = fbx_wrapperPINVOKE.FbxNodeAttribute_GetNodeCount(swigCPtr);
    return ret;
  }

  public FbxNode GetNode(int pIndex) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxNodeAttribute_GetNode__SWIG_0(swigCPtr, pIndex);
    FbxNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNode(cPtr, false);
    return ret;
  }

  public FbxNode GetNode() {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxNodeAttribute_GetNode__SWIG_1(swigCPtr);
    FbxNode ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNode(cPtr, false);
    return ret;
  }

  public enum EType {
    eUnknown,
    eNull,
    eMarker,
    eSkeleton,
    eMesh,
    eNurbs,
    ePatch,
    eCamera,
    eCameraStereo,
    eCameraSwitcher,
    eLight,
    eOpticalReference,
    eOpticalMarker,
    eNurbsCurve,
    eTrimNurbsSurface,
    eBoundary,
    eNurbsSurface,
    eShape,
    eLODGroup,
    eSubDiv,
    eCachedEffect,
    eLine
  }

}

}
