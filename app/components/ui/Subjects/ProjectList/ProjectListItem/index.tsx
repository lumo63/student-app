import { Flex, Heading, ListItem, Text } from '@chakra-ui/react'
import React, { FC } from 'react'
import { Linker, LinkType } from '../../../../Linker'
import { Project } from '../../../../../api/hooks/project'
import moment from 'moment'

interface Props {
  project: Project
}

export const ProjectListItem: FC<Props> = ({ project }) => (
  <ListItem
    paddingBottom="20px"
    px="20px"
    backgroundColor="white"
    borderRadius="12px"
    marginBottom="20px"
  >
    <Flex
      my="12px"
      minWidth="300px"
      justifyContent="space-between"
      borderRadius="12px"
      alignItems="center"
    >
      <Linker type={LinkType.Projects} typeKey={project.projectKey}>
        <Heading fontSize="2xl">{project.name}</Heading>
      </Linker>
      <Text mr="24px" fontSize="20px">
        {moment(project.deadlineTime).locale('pl').format('LL')}
      </Text>
    </Flex>

    <Flex
      borderRadius="12px"
      padding="15px"
      backgroundColor="#E4D3EB"
      flexDir="column"
    >
      <Flex width="100%" justifyContent="space-between">
        <Text fontSize="20px">{project.categoryName}</Text>
        <Text
          borderRadius="12px"
          backgroundColor="white"
          paddingLeft="10px"
          paddingRight="10px"
          fontSize="20px"
        >
          {project.projectStatusName}
        </Text>
      </Flex>
      {project.necessaryToPass && (
        <Text color="#3B2E61">Wymagany do zdania przedmiotu</Text>
      )}
    </Flex>
  </ListItem>
)
