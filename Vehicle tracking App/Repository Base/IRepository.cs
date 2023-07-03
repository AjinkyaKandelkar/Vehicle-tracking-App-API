using Vehicle_tracking_App.Data_Access.DTO;

namespace Vehicle_tracking_App.Repository
{
    public interface IRepository<TDataModel>
    {
        Task<List<TViewModel>> GetAllAsync<TViewModel>();

        Task<TViewModel?> GetByIdAsync<TViewModel>(int id) where TViewModel : ViewModelBase;

        Task CreateAsync(TDataModel entity);

        Task UpdateAsync(TDataModel entity);

        Task DeleteAsync(int id);

        Task<bool> Exists(int id);
    }
}
