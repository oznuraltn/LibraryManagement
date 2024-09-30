
using LibraryManagement.ConsoleUI.Models;

namespace LibraryManagement.ConsoleUI.Repository;

public class MemberRepository : BaseRepository, IMemberRepository
{
    Member? IMemberRepository.Add(Member member)
    {
        throw new NotImplementedException();
    }

    List<Member> IMemberRepository.GetAll()
    {
        throw new NotImplementedException();
    }

    Member? IMemberRepository.GetById(int id)
    {
        throw new NotImplementedException();
    }

    Member? IMemberRepository.Remove(int id)
    {
        throw new NotImplementedException();
    }

    Member? IMemberRepository.Update(Member member)
    {
        throw new NotImplementedException();
    }
}
