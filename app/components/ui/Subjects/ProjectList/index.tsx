import { Flex, Heading, List } from '@chakra-ui/react'
import { ProjectListItem } from './ProjectListItem'
import { useProjectForSubject } from '../../../../api/hooks/project'
import { Container } from '../Container'
import React, { FC } from 'react'
import { Color } from '../../../../consts/colors'

interface Props {
  subjectKey: string | undefined
}

export const ProjectList: FC<Props> = ({ subjectKey }) => {
  const { projects } = useProjectForSubject(subjectKey)

  return (
    <Flex
      h="100%"
      w="100%"
      borderRadius="15px"
      display="flex"
      alignItems="center"
      backgroundColor={Color.BlackPurple}
      flexDir="column"
    >
      <Heading mx="40px" mt="20px" color={Color.White}>
        PROJEKTY
      </Heading>

      <List
        px="20px"
        w="100%"
        display="flex"
        flexDir="column"
        marginTop="10px"
        overflow="auto"
        css={{
          '&::-webkit-scrollbar': {
            width: '10px',
          },
          '&::-webkit-scrollbar-track': {
            width: '6px',
            background: '#ffffff',
            borderRadius: '24px',
          },
          '&::-webkit-scrollbar-thumb': {
            background: '#8C8C8C',
            borderRadius: '24px',
          },
        }}
      >
        {projects?.map((project) => (
          <ProjectListItem key={project.projectKey} project={project} />
        ))}
      </List>
    </Flex>
  )
}
