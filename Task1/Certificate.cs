

using System.Runtime.ConstrainedExecution;

public class Certificate {

    public Certificate(int id, IEnumerable<Certificate>? prerequisites = null) {
        this.Id = id;
        this.Prerequisites = prerequisites ?? [];
    }

    public int Id { get; init; }

    public IEnumerable<Certificate> Prerequisites { get; set; } = [];

}
