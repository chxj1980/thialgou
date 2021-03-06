/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.thialgou.ioWRAP {

using System;
using System.Runtime.InteropServices;

public class h264Decoder : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal h264Decoder(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(h264Decoder obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~h264Decoder() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          ioWRAPPINVOKE.delete_h264Decoder(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public h264Decoder(string inputFilePath, string outputFilePath) : this(ioWRAPPINVOKE.new_h264Decoder(inputFilePath, outputFilePath), true) {
  }

  public virtual bool IsInitialized() {
    bool ret = ioWRAPPINVOKE.h264Decoder_IsInitialized(swigCPtr);
    return ret;
  }

  public virtual bool SetIoEventHdr(h264HdrEventParsing pIoEventHdr) {
    bool ret = ioWRAPPINVOKE.h264Decoder_SetIoEventHdr(swigCPtr, h264HdrEventParsing.getCPtr(pIoEventHdr));
    return ret;
  }

  public virtual bool Decode(uint frameCount) {
    bool ret = ioWRAPPINVOKE.h264Decoder_Decode(swigCPtr, frameCount);
    return ret;
  }

}

}
