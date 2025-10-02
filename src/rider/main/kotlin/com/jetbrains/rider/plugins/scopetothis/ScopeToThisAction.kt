package com.jetbrains.rider.plugins.scopetothis

import com.intellij.openapi.actionSystem.AnAction
import com.intellij.openapi.actionSystem.AnActionEvent
import com.jetbrains.rider.projectView.actions.workspace.AttachFolderAction
import com.jetbrains.rider.projectView.workspace.getProjectModelEntity
import com.jetbrains.rider.projectView.workspace.getVirtualFileAsParent
import com.jetbrains.rider.projectView.workspace.isDirectory

class ScopeToThisAction : AnAction("Scope to This") {
  override fun update(e: AnActionEvent) {
    e.presentation.isEnabledAndVisible = e.project != null && e.dataContext.getProjectModelEntity()?.isDirectory() == true
  }

  override fun actionPerformed(p0: AnActionEvent) {
    val directory = p0.dataContext.getProjectModelEntity()?.getVirtualFileAsParent() ?: return
    val project = p0.project ?: return
    AttachFolderAction.execute(directory, project, true)
  }
}
