using FortnoxAPILibrary;
using FortnoxAPILibrary.Entities;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public interface IAccountConnector
	{
        [SearchParameter("filter")]
		Filter.Account? FilterBy { get; set; }


        [SearchParameter]
		string SRU { get; set; }
		Account Update(Account account);

		Account Create(Account account);

		Account Get(int? id);

		void Delete(int? id);

		EntityCollection<AccountSubset> Find();

	}
}
