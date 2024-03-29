import React, { FC, useContext, useEffect, useState } from 'react'
import { ReusableModal } from '../../components/ReusableModal/Modal'
import { GlobalDataContext } from '../../components/Auth/Provider'
import { EntityTypes, ModalType } from '../../types/types'
import { useForm } from 'react-hook-form'
import { CSelect } from '../../components/Forms/CSelect/CSelect'
import { Checkbox, FormLabel, Input } from '@chakra-ui/react'
import { CTextArea } from '../../components/Forms/CTextarea/CTextArea'
import 'react-day-picker/lib/style.css'
import { CDayPicker } from '../../components/DayPicker/DayPicker'
import { useRouter } from 'next/router'
import { SubjectCreateModel } from '../../api/actions/subject'
import { useSubjects } from '../../api/hooks/subject'
import { postProject, ProjectFormData } from '../../api/actions/project'
import { useProjectCategory, useProjectTypes } from '../../api/hooks/project'

export const AddProject: FC = () => {
  const { push } = useRouter()
  const { projectTypes } = useProjectTypes()
  const [projectType, setProjectType] = useState<string>()
  const { projectCategories } = useProjectCategory(projectType)
  const { getAsKeyValue } = useSubjects()
  const { handleSubmit, register } = useForm<SubjectCreateModel>()
  const { modalType, setModalType } = useContext(GlobalDataContext)
  const [datePicked, setDatePicked] = useState(new Date())

  useEffect(() => {
    if (projectTypes) {
      const lookForExam = modalType === ModalType.AddExam
      const lookForProject = modalType === ModalType.AddProject

      Object.keys(projectTypes).forEach((projectTypeKey) => {
        if (
          (lookForExam &&
            projectTypes[projectTypeKey] === EntityTypes.Egzamin) ||
          (lookForProject &&
            projectTypes[projectTypeKey] === EntityTypes.Projekt)
        ) {
          setProjectType(projectTypeKey)
        }
      })
    }
  }, [projectTypes])

  const onProjectCategoryChange = (e: React.ChangeEvent<HTMLSelectElement>) => {
    setProjectType(e.target.value)
  }

  const onProjectSubmit = async (data: ProjectFormData) => {
    await postProject({
      ...data,
      deadlineTime: datePicked.toISOString(),
    })
      .then(() => setModalType(ModalType.None))
      .then(() => push('/projects'))
  }
  return (
    <ReusableModal
      isOpen={modalType !== ModalType.None}
      headerText={{
        title: 'Nowy projekt',
        description:
          'Po wpisaniu wymaganych danych przejdziesz do widoku przedmiotu',
      }}
      onClose={() => setModalType(ModalType.None)}
      onSubmit={handleSubmit(onProjectSubmit)}
      acceptButtonText="Dodaj projekt"
      cancelButtonText="Anuluj"
    >
      <FormLabel htmlFor="projectName">Nazwa projektu</FormLabel>
      <Input
        marginBottom={15}
        id="projectName"
        name="name"
        ref={register({ required: true })}
      />
      <CSelect
        name="subjectKey"
        ref={register({ required: true })}
        selectOptions={getAsKeyValue()}
        labelText="Wybierz przedmiot projektu"
      />
      <CSelect
        defaultValue={projectType}
        name="typeDefinitionKey"
        ref={register({ required: true })}
        selectOptions={projectTypes}
        onChange={onProjectCategoryChange}
        labelText="Wybierz typ projektu"
      />
      <CSelect
        name="categoryKey"
        ref={register({ required: true })}
        selectOptions={projectCategories}
        labelText="Wybierz z kategorii"
      />
      <CTextArea name="description" ref={register()} labelText="Notatka" />
      <Checkbox colorScheme="red" name="hasProjectToPass" ref={register()}>
        Projekt niezbędny dla zaliczenia
      </Checkbox>
      <CDayPicker date={datePicked} onDateChange={setDatePicked} />
    </ReusableModal>
  )
}
