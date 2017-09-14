#include <stdlib.h>
#include <cstdio>
#include <math.h>
// this kernel computes the vector sum c = a + b
// each thread performs one pair-wise addition
__global__ void vector_add(const float *a,
                           const float *b,
                           float *c,
                           const size_t n){
 unsigned int i = threadIdx.x + blockDim.x * blockIdx.x;
  // avoid accessing out of bounds elements
  if(i < n)
  {
    // sum elements
    c[i] = a[i] + b[i];
  }
}

int main(void)
{
  // create arrays of 1M elements
  int num_elements = 0 ;
  printf("Enter number of elements to add");
  scanf("%d", &num_elements);
  // compute the size of the arrays in bytes
  const int num_bytes = num_elements * sizeof(float);

  // points to host & device arrays
  float *array_a;
  float *array_b;
  float *array_c;
  // cudaMalloc the device arrays
 cudaMallocManaged((void**)&array_a, num_bytes);
 cudaMallocManaged((void**)&array_b, num_bytes);
 cudaMallocManaged((void**)&array_c, num_bytes);

  // initialize host_array_a & host_array_b
  for(int i = 0; i < num_elements; ++i)
  {
    // make array a a linear ramp
    array_a[i] = (float)i;

    // make array b random
    array_b[i] = (float)rand() / RAND_MAX;
  }
    
  
  vector_add <<< ceil(num_elements/32.0), 32>>>
(array_a, array_b, array_c, num_elements);
cudaDeviceSynchronize();
  for(int i = 0; i < num_elements; ++i)
  {
    printf("result %d: %1.1f + %7.1f = %7.1f\n", i, array_a[i], array_b[i], array_c[i]);
  }

  cudaFree(array_a);
  cudaFree(array_b);
  cudaFree(array_c);
}

