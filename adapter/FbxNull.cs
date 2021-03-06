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

public class FbxNull : FbxNodeAttribute {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxNull(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxNull_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxNull obj) {
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
      fbx_wrapperPINVOKE.FbxNull_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxNull_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxNull_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxNull Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxNull_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxNull ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNull(cPtr, false);
    return ret;
  }

  public new static FbxNull Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxNull_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxNull ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxNull(cPtr, false);
    return ret;
  }

  public override FbxNodeAttribute.EType GetAttributeType() {
    FbxNodeAttribute.EType ret = (FbxNodeAttribute.EType)fbx_wrapperPINVOKE.FbxNull_GetAttributeType(swigCPtr);
    return ret;
  }

  public void Reset() {
    fbx_wrapperPINVOKE.FbxNull_Reset(swigCPtr);
  }

  public double GetSizeDefaultValue() {
    double ret = fbx_wrapperPINVOKE.FbxNull_GetSizeDefaultValue(swigCPtr);
    return ret;
  }

  public static string sSize {
    set {
      fbx_wrapperPINVOKE.FbxNull_sSize_set(value);
    } 
    get {
      string ret = fbx_wrapperPINVOKE.FbxNull_sSize_get();
      return ret;
    } 
  }

  public static string sLook {
    set {
      fbx_wrapperPINVOKE.FbxNull_sLook_set(value);
    } 
    get {
      string ret = fbx_wrapperPINVOKE.FbxNull_sLook_get();
      return ret;
    } 
  }

  public static double sDefaultSize {
    get {
      double ret = fbx_wrapperPINVOKE.FbxNull_sDefaultSize_get();
      return ret;
    } 
  }

  public static FbxNull.ELook sDefaultLook {
    get {
      FbxNull.ELook ret = (FbxNull.ELook)fbx_wrapperPINVOKE.FbxNull_sDefaultLook_get();
      return ret;
    } 
  }

  public FbxPropertyTDouble Size {
    set {
      fbx_wrapperPINVOKE.FbxNull_Size_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxNull_Size_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_FbxPropertyTT_FbxNull__ELook_t Look {
    set {
      fbx_wrapperPINVOKE.FbxNull_Look_set(swigCPtr, SWIGTYPE_p_FbxPropertyTT_FbxNull__ELook_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxNull_Look_get(swigCPtr);
      SWIGTYPE_p_FbxPropertyTT_FbxNull__ELook_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FbxPropertyTT_FbxNull__ELook_t(cPtr, false);
      return ret;
    } 
  }

  public override FbxObject Copy(FbxObject pObject) {
    FbxObject ret = new FbxObject(fbx_wrapperPINVOKE.FbxNull_Copy(swigCPtr, FbxObject.getCPtr(pObject)), false);
    if (fbx_wrapperPINVOKE.SWIGPendingException.Pending) throw fbx_wrapperPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override FbxStringList GetTypeFlags() {
    FbxStringList ret = new FbxStringList(fbx_wrapperPINVOKE.FbxNull_GetTypeFlags(swigCPtr), true);
    return ret;
  }

  public enum ELook {
    eNone,
    eCross
  }

}

}
