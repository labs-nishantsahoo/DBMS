#include <stdlib.h>
#include <stdio.h>
#include <math.h>

#define HANDLE_ERROR( err ) (HandleError( err, __FILE__, __LINE__ ))

static void HandleError( cudaError_t err, const char *file, int line ) 
{
       if (err != cudaSuccess) 
    {
	 printf( "%s in %s at line %d\n", cudaGetErrorString( err ), file, line );
	 exit( EXIT_FAILURE );
    }
}

// this kernel computes the vector sum c = a + b
// each thread performs one pair-wise addition
__global__ void vector_add(const float *a,
                           const float *b,
                           float *c,
                           const size_t n)
{
  // compute the global element index this thread should process
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
  float *device_array_a = 0;
  float *device_array_b = 0;
  float *device_array_c = 0;

  float *host_array_a   = 0;
  float *host_array_b   = 0;
  float *host_array_c   = 0;

  // malloc the host arrays
  host_array_a = (float*)malloc(num_bytes);
  host_array_b = (float*)malloc(num_bytes);
  host_array_c = (float*)malloc(num_bytes);

  // cudaMalloc the device arrays
  HANDLE_ERROR(cudaMalloc((void**)&device_array_a, num_bytes));
  HANDLE_ERROR(cudaMalloc((void**)&device_array_b, num_bytes));
  HANDLE_ERROR(cudaMalloc((void**)&device_array_c, num_bytes));


  // initialize host_array_a & host_array_b
  for(int i = 0; i < num_elements; ++i)
  {
    // make array a a linear ramp
    host_array_a[i] = (float)i;

    // make array b random
    host_array_b[i] = (float)rand() / RAND_MAX;
  }

 
       
  // copy arrays a & b to the device memory space
  HANDLE_ERROR(cudaMemcpy(device_array_a, host_array_a, num_bytes, cudaMemcpyHostToDevice));
  HANDLE_ERROR(cudaMemcpy(device_array_b, host_array_b, num_bytes, cudaMemcpyHostToDevice));



  // launch the kernel
    
  vector_add <<< ceil(num_elements/32.0), 32>>>(device_array_a, device_array_b, device_array_c, num_elements);

  // copy the result back to the host memory space
  HANDLE_ERROR(cudaMemcpy(host_array_c, device_array_c, num_bytes, cudaMemcpyDeviceToHost));

  for(int i = 0; i < num_elements; ++i)
  {
    printf("result %d: %1.1f + %7.1f = %7.1f\n", i, host_array_a[i], host_array_b[i], host_array_c[i]);
  }

  // deallocate memory
  free(host_array_a);
  free(host_array_b);
  free(host_array_c);

  HANDLE_ERROR(cudaFree(device_array_a));
  HANDLE_ERROR(cudaFree(device_array_b));
  HANDLE_ERROR(cudaFree(device_array_c));
}

