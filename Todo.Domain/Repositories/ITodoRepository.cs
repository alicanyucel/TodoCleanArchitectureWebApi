
namespace Todo.Domain.Models;
// inernal aynı namesapcae içerinden eriilebilir
//public ise her yerden erişlebilir
public interface ITodoRepositorycs
{
    // task gördüğünüz yerde asenkron bir işlem vardor cancellationtoken işlem devam ediyor anlamında asenkron oldugu için vermem gerekşyor best practise olarak
    Task AddAsync(Todo item,CancellationToken cancellationToken=default);

}
