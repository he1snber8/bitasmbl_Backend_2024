using AutoMapper;
using MediatR;
using Project_Backend_2024.DTO;
using Project_Backend_2024.Facade.Interfaces;

namespace Project_Backend_2024.Services.CommandServices.Skills.Create;

 public class CreateSkillCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
     : IRequestHandler<CreateSkillCommand, Unit>
 {
     public async Task<Unit> Handle(CreateSkillCommand request, CancellationToken cancellationToken)
     {
         var skill = mapper.Map<Skill>(request);
         
         unitOfWork.SkillRepository.Insert(skill); 
         
         await unitOfWork.SaveChangesAsync();
          
         return Unit.Value;
     }
 }