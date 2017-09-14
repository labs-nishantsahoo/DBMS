import pycuda.autoinit
import pycuda.driver as drv
import numpy
import math

from pycuda.compiler import SourceModule
mod = SourceModule("""
__global__ void vectorAdd(int *c, int *a, int *b, int N)
{
  const int i = threadIdx.x+ blockIdx.x*blockDim.x;
  if( i< N)
  c[i] = a[i] + b[i];
}
""")

vectorAdd = mod.get_function("vectorAdd")

value=raw_input('Enter number count: ')
N = numpy.int32(value)
a = numpy.random.randint(N,size=N).astype(numpy.int32)
b = numpy.random.randint(N,size=N).astype(numpy.int32)
c = numpy.zeros_like(a)

numThreads=64;
numBlocks= int (math.ceil(N/64.0))
vectorAdd(
        drv.Out(c), drv.In(a), drv.In(b), N,
        block=( numThreads,1,1), grid=(numBlocks,1,1))
for i in range (0, N):
	print a[i], "+" , b[i], "=", c[i]
print c-(a+b)
