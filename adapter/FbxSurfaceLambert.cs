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

public class FbxSurfaceLambert : FbxSurfaceMaterial {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FbxSurfaceLambert(global::System.IntPtr cPtr, bool cMemoryOwn) : base(fbx_wrapperPINVOKE.FbxSurfaceLambert_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxSurfaceLambert obj) {
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
      fbx_wrapperPINVOKE.FbxSurfaceLambert_ClassId_set(FbxClassId.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_ClassId_get();
      FbxClassId ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxClassId(cPtr, false);
      return ret;
    } 
  }

  public override FbxClassId GetClassId() {
    FbxClassId ret = new FbxClassId(fbx_wrapperPINVOKE.FbxSurfaceLambert_GetClassId(swigCPtr), true);
    return ret;
  }

  public new static FbxSurfaceLambert Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxSurfaceLambert ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSurfaceLambert(cPtr, false);
    return ret;
  }

  public new static FbxSurfaceLambert Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxSurfaceLambert ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxSurfaceLambert(cPtr, false);
    return ret;
  }

  public FbxPropertyTDouble3 Emissive {
    set {
      fbx_wrapperPINVOKE.FbxSurfaceLambert_Emissive_set(swigCPtr, FbxPropertyTDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_Emissive_get(swigCPtr);
      FbxPropertyTDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble EmissiveFactor {
    set {
      fbx_wrapperPINVOKE.FbxSurfaceLambert_EmissiveFactor_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_EmissiveFactor_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble3 Ambient {
    set {
      fbx_wrapperPINVOKE.FbxSurfaceLambert_Ambient_set(swigCPtr, FbxPropertyTDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_Ambient_get(swigCPtr);
      FbxPropertyTDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble AmbientFactor {
    set {
      fbx_wrapperPINVOKE.FbxSurfaceLambert_AmbientFactor_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_AmbientFactor_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble3 Diffuse {
    set {
      fbx_wrapperPINVOKE.FbxSurfaceLambert_Diffuse_set(swigCPtr, FbxPropertyTDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_Diffuse_get(swigCPtr);
      FbxPropertyTDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble DiffuseFactor {
    set {
      fbx_wrapperPINVOKE.FbxSurfaceLambert_DiffuseFactor_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_DiffuseFactor_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble3 NormalMap {
    set {
      fbx_wrapperPINVOKE.FbxSurfaceLambert_NormalMap_set(swigCPtr, FbxPropertyTDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_NormalMap_get(swigCPtr);
      FbxPropertyTDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble3 Bump {
    set {
      fbx_wrapperPINVOKE.FbxSurfaceLambert_Bump_set(swigCPtr, FbxPropertyTDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_Bump_get(swigCPtr);
      FbxPropertyTDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble BumpFactor {
    set {
      fbx_wrapperPINVOKE.FbxSurfaceLambert_BumpFactor_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_BumpFactor_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble3 TransparentColor {
    set {
      fbx_wrapperPINVOKE.FbxSurfaceLambert_TransparentColor_set(swigCPtr, FbxPropertyTDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_TransparentColor_get(swigCPtr);
      FbxPropertyTDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble TransparencyFactor {
    set {
      fbx_wrapperPINVOKE.FbxSurfaceLambert_TransparencyFactor_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_TransparencyFactor_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble3 DisplacementColor {
    set {
      fbx_wrapperPINVOKE.FbxSurfaceLambert_DisplacementColor_set(swigCPtr, FbxPropertyTDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_DisplacementColor_get(swigCPtr);
      FbxPropertyTDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble DisplacementFactor {
    set {
      fbx_wrapperPINVOKE.FbxSurfaceLambert_DisplacementFactor_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_DisplacementFactor_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble3 VectorDisplacementColor {
    set {
      fbx_wrapperPINVOKE.FbxSurfaceLambert_VectorDisplacementColor_set(swigCPtr, FbxPropertyTDouble3.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_VectorDisplacementColor_get(swigCPtr);
      FbxPropertyTDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble3(cPtr, false);
      return ret;
    } 
  }

  public FbxPropertyTDouble VectorDisplacementFactor {
    set {
      fbx_wrapperPINVOKE.FbxSurfaceLambert_VectorDisplacementFactor_set(swigCPtr, FbxPropertyTDouble.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_VectorDisplacementFactor_get(swigCPtr);
      FbxPropertyTDouble ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxPropertyTDouble(cPtr, false);
      return ret;
    } 
  }

  public static FbxDouble3 sEmissiveDefault {
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_sEmissiveDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static double sEmissiveFactorDefault {
    get {
      double ret = fbx_wrapperPINVOKE.FbxSurfaceLambert_sEmissiveFactorDefault_get();
      return ret;
    } 
  }

  public static FbxDouble3 sAmbientDefault {
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_sAmbientDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static double sAmbientFactorDefault {
    get {
      double ret = fbx_wrapperPINVOKE.FbxSurfaceLambert_sAmbientFactorDefault_get();
      return ret;
    } 
  }

  public static FbxDouble3 sDiffuseDefault {
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_sDiffuseDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static double sDiffuseFactorDefault {
    get {
      double ret = fbx_wrapperPINVOKE.FbxSurfaceLambert_sDiffuseFactorDefault_get();
      return ret;
    } 
  }

  public static FbxDouble3 sBumpDefault {
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_sBumpDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static FbxDouble3 sNormalMapDefault {
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_sNormalMapDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static double sBumpFactorDefault {
    get {
      double ret = fbx_wrapperPINVOKE.FbxSurfaceLambert_sBumpFactorDefault_get();
      return ret;
    } 
  }

  public static FbxDouble3 sTransparentDefault {
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_sTransparentDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static double sTransparencyFactorDefault {
    get {
      double ret = fbx_wrapperPINVOKE.FbxSurfaceLambert_sTransparencyFactorDefault_get();
      return ret;
    } 
  }

  public static FbxDouble3 sDisplacementDefault {
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_sDisplacementDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static double sDisplacementFactorDefault {
    get {
      double ret = fbx_wrapperPINVOKE.FbxSurfaceLambert_sDisplacementFactorDefault_get();
      return ret;
    } 
  }

  public static FbxDouble3 sVectorDisplacementDefault {
    get {
      global::System.IntPtr cPtr = fbx_wrapperPINVOKE.FbxSurfaceLambert_sVectorDisplacementDefault_get();
      FbxDouble3 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDouble3(cPtr, false);
      return ret;
    } 
  }

  public static double sVectorDisplacementFactorDefault {
    get {
      double ret = fbx_wrapperPINVOKE.FbxSurfaceLambert_sVectorDisplacementFactorDefault_get();
      return ret;
    } 
  }

}

}