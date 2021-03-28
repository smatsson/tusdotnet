#if pipelines

using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;
using tusdotnet.Models;

namespace tusdotnet.Interfaces
{
    public interface ITusPipelineStore : ITusStore
    {
		/// <summary>
		/// Write data to the file using the provided pipe reader.
		/// The implementation must throw <exception cref="TusStoreException"></exception>
		/// if the streams length exceeds the upload length of the file.
		/// </summary>
		/// <param name="fileId">The id of the file to write</param>
		/// <param name="stream">The request input stream from the client</param>
		/// <param name="cancellationToken">Cancellation token to use when cancelling</param>
		/// <returns>The number of bytes written</returns>
		Task<long> AppendDataAsync(string fileId, PipeReader stream, CancellationToken cancellationToken);
	}
}

#endif