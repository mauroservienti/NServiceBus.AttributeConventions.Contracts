using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;
using PublicApiGenerator;
using System.Runtime.CompilerServices;

namespace NServiceBus.AttributeConventions.Contracts.Tests.API
{
    public class APIApprovals
    {
        [Test]
        [UseReporter(typeof(DiffReporter))]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public void Approve_API()
        {
            var publicApi = ApiGenerator.GeneratePublicApi(typeof(MessageAttribute).Assembly, options: null);

            Approvals.Verify(publicApi);
        }
    }
}
