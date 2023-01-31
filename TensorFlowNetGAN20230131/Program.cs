// NuGet Packages:
/*
Install-Package System.Drawing.Common
Install-Package SciSharp.Tensorflow.Redist-Windows-GPU
Install-Package Tensorflow.Keras
 */

using static Tensorflow.Binding;
using static Tensorflow.KerasApi;

tf.enable_eager_execution();

var data = keras.datasets.mnist.load_data();

/*

System.TypeInitializationException
  HResult=0x80131534
  Message=The type initializer for 'Tensorflow.KerasApi' threw an exception.
  Source=Tensorflow.Keras
  StackTrace:
   at Tensorflow.KerasApi.get_keras()
   at Program.<Main>$(String[] args) in C:\Users\darla\source\repos\TensorFlowNetGAN20230131\TensorFlowNetGAN20230131\Program.cs:line 20

  This exception was originally thrown at this call stack:
    Tensorflow.KerasApi.KerasApi()

Inner Exception 1:
TypeLoadException: Method 'SimpleRNN' in type 'Tensorflow.Keras.Layers.LayersApi' from assembly 'Tensorflow.Keras, Version=0.10.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51' does not have an implementation.

*/