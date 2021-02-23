import { Subject, useSubject, useSubjectTypes } from '../../api/hooks/subject'
import { useRouter } from 'next/router'
import React, { useState } from 'react'
import {
  Flex,
  Grid,
  GridItem,
  Skeleton,
  Text,
  Checkbox,
  Switch,
  Textarea,
  useToast,
} from '@chakra-ui/react'
import { ProjectList } from '../../components/ui/Subjects/ProjectList'
import { useEventsForSubject } from '../../api/hooks/event'
import { EventList } from '../../components/ui/common/EventList'
import { subjectPut } from '../../api/actions/subject'
import { InputText } from '../../components/InputText'
import { SelectText } from '../../components/SelectText'
import produce from 'immer'

const SubjectPage = () => {
  const toast = useToast()
  const { subjectTypes } = useSubjectTypes()

  const { query } = useRouter()
  const { subject, isLoading, mutate } = useSubject(String(query.key))
  const { events } = useEventsForSubject(String(query.key))

  const [isSubjectNameClicked, setIsSubjectNameClicked] = useState(false)

  type KeysEnum<T> = { [P in keyof Required<T>]: true }

  const onSubjectModified = async (
    key: keyof Subject,
    value: string | boolean,
  ) => {
    console.log(key)
    const subjectModified = produce(subject, (draft) => {
      if (draft) {
        // @ts-ignore https://github.com/microsoft/TypeScript/issues/31663
        draft[key] = value
      }
      return draft
    })

    if (subjectModified && subjectModified !== subject) {
      await mutate(subjectModified, false)
      await subjectPut(subjectModified)
      await mutate()

      toast({
        title: 'Przedmiot został zmodyfikowany pomyślnie',
        status: 'success',
        duration: 5000,
        isClosable: true,
      })
    }
  }

  return (
    <Grid width="100%" h="100%" gridColumnGap="50px" gridRowGap="20px">
      <GridItem
        borderRadius="12px"
        gridRowStart="1"
        gridRowEnd="2"
        gridColumnStart="1"
        gridColumnEnd="3"
        backgroundColor="white"
      >
        <Skeleton
          display="flex"
          borderRadius="12px"
          justifyContent="space-between"
          alignItems="center"
          isLoaded={!!subject}
          w="100%"
          h="100%"
          paddingX="30px"
        >
          {subject && (
            <>
              <Flex alignItems="center" width="50%">
                <InputText
                  fontSize="4xl"
                  keyModified="name"
                  text={subject.name}
                  onTextChanged={onSubjectModified}
                  title={`Kliknij aby zmienić tytuł przedmiotu ${subject.name}`}
                />
              </Flex>
              <Flex justifyContent="flex-start" width="25%">
                <SelectText
                  fontSize="2xl"
                  keyModified="typeDefinitionKey"
                  text={subject.typeDefinitionName}
                  selectedKey={subject.typeDefinitionKey}
                  options={subjectTypes}
                  onChange={onSubjectModified}
                  title="Kliknij aby wybrać typ przedmiotu"
                />
              </Flex>
              <Flex justifyContent="flex-end" width="25%">
                <Flex
                  onClick={async (e) => {
                    await onSubjectModified('isPassed', !subject?.isPassed)
                    e.stopPropagation()
                    e.preventDefault()
                  }}
                  cursor="pointer"
                  paddingLeft="20px"
                  borderRadius="12px"
                  backgroundColor={subject?.isPassed ? '#4CD964' : '#FA0000'}
                  alignItems="center"
                >
                  <Checkbox
                    onChange={(e) => {
                      e.stopPropagation()
                      e.preventDefault()
                    }}
                    isChecked={subject.isPassed}
                    size="lg"
                    colorScheme="#4CD964"
                  />
                  <Text
                    paddingX="20px"
                    fontSize="2xl"
                    color="white"
                    display="flex"
                    justifyContent="center"
                  >
                    {subject?.isPassed ? 'zaliczony' : 'niezaliczony'}
                  </Text>
                </Flex>
              </Flex>
            </>
          )}
        </Skeleton>
      </GridItem>

      <GridItem
        gridColumnStart="1"
        gridColumnEnd="3"
        gridRowStart="2"
        gridRowEnd="4"
        backgroundColor="white"
        borderRadius="12px"
      >
        <Textarea
          height="100%"
          borderRadius="12px"
          placeholder="Opis przedmiotu"
          fontSize="2xl"
          resize="none"
          defaultValue={subject?.description}
          onBlur={async (e) =>
            await onSubjectModified('description', e.currentTarget.value)
          }
          border="transparent"
          css={{
            '&::-webkit-scrollbar': {
              width: '10px',
            },
            '&::-webkit-scrollbar-track': {
              width: '6px',
              background: '#dadada',
              // borderRadius: '24px',
            },
            '&::-webkit-scrollbar-thumb': {
              background: '#271257',
              borderRadius: '24px',
            },
          }}
        />
      </GridItem>
      <GridItem
        gridColumnStart="1"
        gridColumnEnd="3"
        gridRowStart="4"
        gridRowEnd="10"
        h="100%"
        w="100%"
        //   overflow="auto"
        // css={{
        //   '&::-webkit-scrollbar': {
        //     width: '10px',
        //   },
        //   '&::-webkit-scrollbar-track': {
        //     width: '6px',
        //     background: '#ffffff',
        //     borderRadius: '24px',
        //   },
        //   '&::-webkit-scrollbar-thumb': {
        //     background: '#8C8C8C',
        //     borderRadius: '24px',
        //   },
        // }}
      >
        <Flex h="100%" w="100%">
          <ProjectList subjectKey={subject?.subjectKey} />
        </Flex>
      </GridItem>
      <GridItem gridColumnStart="3" gridRowStart="1" gridRowEnd="10" h="100%">
        <EventList events={events} />
      </GridItem>
    </Grid>
  )
}

export default SubjectPage
